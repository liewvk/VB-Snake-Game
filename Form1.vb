Public Class Form1
    Dim snake As New List(Of Point)
    Dim food As Point
    Dim rnd As New Random()

    Dim cellSize As Integer = 20
    Dim currentDirection As String = "Right"

    Dim score As Integer = 0
    Dim gameStarted As Boolean = False
    Dim gameOver As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "Classic Snake Game"
        lblInstruction.Text = "Use the arrow keys to move the snake."
        lblScore.Text = "Score: 0"
        lblStatus.Text = "Click Start to begin."
    End Sub

    Private Sub StartGame()
        snake.Clear()

        snake.Add(New Point(5, 5))
        snake.Add(New Point(4, 5))
        snake.Add(New Point(3, 5))

        currentDirection = "Right"
        score = 0
        gameStarted = True
        gameOver = False

        lblScore.Text = "Score: 0"
        lblStatus.Text = "Game in progress."

        GenerateFood()

        gameTimer.Interval = 150
        gameTimer.Start()

        pnlGameArea.Invalidate()
    End Sub

    Private Sub GenerateFood()
        Dim maxX As Integer = pnlGameArea.Width \ cellSize
        Dim maxY As Integer = pnlGameArea.Height \ cellSize

        food = New Point(rnd.Next(0, maxX), rnd.Next(0, maxY))
    End Sub

    Protected Overrides Function ProcessCmdKey(
    ByRef msg As Message,
    keyData As Keys
) As Boolean

        If gameStarted AndAlso Not gameOver Then
            Select Case keyData And Keys.KeyCode
                Case Keys.Up
                    If currentDirection <> "Down" Then
                        currentDirection = "Up"
                    End If

                Case Keys.Down
                    If currentDirection <> "Up" Then
                        currentDirection = "Down"
                    End If

                Case Keys.Left
                    If currentDirection <> "Right" Then
                        currentDirection = "Left"
                    End If

                Case Keys.Right
                    If currentDirection <> "Left" Then
                        currentDirection = "Right"
                    End If

                Case Else
                    Return MyBase.ProcessCmdKey(msg, keyData)
            End Select

            ' Arrow key handled: prevent control navigation.
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        Dim head As Point = snake(0)
        Dim newHead As Point = head

        Select Case currentDirection
            Case "Up"
                newHead.Y -= 1
            Case "Down"
                newHead.Y += 1
            Case "Left"
                newHead.X -= 1
            Case "Right"
                newHead.X += 1
        End Select

        snake.Insert(0, newHead)

        If snake(0) = food Then
            score += 10
            lblScore.Text = "Score: " & score.ToString()
            GenerateFood()
        Else
            snake.RemoveAt(snake.Count - 1)
        End If

        If CheckWallCollision() OrElse CheckSelfCollision() Then
            ShowGameOver()
            Exit Sub
        End If

        pnlGameArea.Invalidate()
    End Sub

    Private Function CheckWallCollision() As Boolean
        Dim head As Point = snake(0)
        Dim maxX As Integer = pnlGameArea.Width \ cellSize
        Dim maxY As Integer = pnlGameArea.Height \ cellSize

        Return head.X < 0 OrElse head.Y < 0 OrElse head.X >= maxX OrElse head.Y >= maxY
    End Function

    Private Function CheckSelfCollision() As Boolean
        Dim head As Point = snake(0)

        For i As Integer = 1 To snake.Count - 1
            If snake(i) = head Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub ShowGameOver()
        gameTimer.Stop()
        gameStarted = False
        gameOver = True
        lblStatus.Text = "Game Over!"
        MessageBox.Show("Game Over! Final Score: " & score.ToString())
    End Sub

    Private Sub pnlGameArea_Paint(sender As Object, e As PaintEventArgs) Handles pnlGameArea.Paint
        For Each segment As Point In snake
            e.Graphics.FillRectangle(Brushes.Green, segment.X * cellSize, segment.Y * cellSize, cellSize, cellSize)
        Next

        e.Graphics.FillEllipse(Brushes.Red, food.X * cellSize, food.Y * cellSize, cellSize, cellSize)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartGame()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        StartGame()
    End Sub

End Class
