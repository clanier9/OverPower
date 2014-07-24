Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

<Serializable> Public Class MissionEvent : Inherits System.Windows.Forms.PictureBox
    Public ID As Integer
    Public effect As String
    Public wide As Boolean = True
    Public placed As Boolean = False
    Public played As Boolean = False
    Public hit As Boolean = False
    Public perm As Boolean = False
    Public attack As Boolean = False
    Public defend As Boolean = False
    Public placedOn As String
    Public hitOn As String
    Public rotated As Boolean = False
    Public commonname As String

    Dim imgFront As String
    Dim imgBack As String

    Public Sub New()
        Width = 128
        Height = 91
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage
        Location = Cursor.Position
    End Sub

    Public Sub New(ByVal eID As Integer)
        ID = eID
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage

        Dim dt As New OPCardsDataSet.eventDataTable
        Dim da As New OPCardsDataSetTableAdapters.eventTableAdapter
        Dim dr As New DataTableReader(dt)

        'find event in database using ID and fill table
        da.FillByID(dt, ID)

        'add event's data
        Using (dr)
            While (dr.Read)
                effect = dr.GetString(dr.GetOrdinal("effect"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
                commonname = dr.GetString(dr.GetOrdinal("commonname"))
            End While
        End Using

        imgFront = imgFront.Replace("/", "\")
        Image = Image.FromFile(imgFront)
        imgBack = "http://overpower.ca/cards/misc/op_back.png"
    End Sub

    Public Sub Parse(ev As MissionEvent)
        ID = ev.ID
        Visible = True

        'add event's data
        effect = ev.effect
        Image = ev.Image
    End Sub
End Class