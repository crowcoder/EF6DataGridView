Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Data.Entity

Public Class Form1

    Dim ctx As New FruitContext()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'We set the columns in the designer so turn off automatic column generation
        DataGridView1.AutoGenerateColumns = False

        'Bring in all the fruit records into "Local" collection
        ctx.FruitDbSet.Load()
        
        ''''' WHERE examples....''''''''
        'You can do a simple one line filter like this:
        'ctx.FruitDbSet.Where(Function(f) f.FruitColor.Equals("red")).Load()
        
        'Or for more elaborate filters:
        'Dim fr = From f In ctx.FruitDbSet
        '         Where f.FruitName = "Apple"
        '         Select f

        'fr.Load()
        ''''''''''''''''''''''''''''''''
        
        'Get all the fruits and wrap them in a BindingList so the grid will allow new rows, etc.
        Dim flist = ctx.FruitDbSet.Local.ToBindingList()
        flist.AllowEdit = True
        flist.AllowNew = True
        flist.AllowRemove = True

        'Bind the grid to the collection
        DataGridView1.DataSource = flist

    End Sub

    ''' <summary>
    ''' Calls SaveChanges on the DbContext.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Async Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ctx.SaveChanges()
        Await ShowMessage()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ctx.Dispose()
    End Sub

    ''' <summary>
    ''' Show success message without blocking the UI.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Async Function ShowMessage() As Task(Of Boolean)

        lblUpdate.Visible = True
        Await Task.Delay(2000)
        lblUpdate.Visible = False
        Return True

    End Function
End Class
