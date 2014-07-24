Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

<Serializable> Public Class Training : Inherits System.Windows.Forms.PictureBox
    Public ID As Integer
    Dim toUseType1 As Char
    Dim toUseType2 As Char
    Dim bonus As Integer
    Public wide As Boolean = False
    Public placed As Boolean = False
    Public played As Boolean = False
    Public hit As Boolean = False
    Public perm As Boolean = False
    Public attack As Boolean = False
    Public defend As Boolean = False
    Public placedOn As String
    Public hitOn As String
    Public commonname As String
    Public rotated = False
    Public ImageFront As Image

    Dim imgFront As String
    Dim imgBack As String

    Public Sub New()
        Width = 64
        Height = 90
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage
        Location = Cursor.Position
    End Sub

    Public Sub New(ByVal trID As Integer)
        ID = trID
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage

        Dim dt As New OPCardsDataSet.trainingDataTable
        Dim da As New OPCardsDataSetTableAdapters.trainingTableAdapter
        Dim dr As New DataTableReader(dt)

        'find training card in database using ID and fill table
        da.FillByID(dt, ID)

        'add training card's data
        Using (dr)
            While (dr.Read)
                toUseType1 = dr.GetString(dr.GetOrdinal("bonus1_skill"))
                toUseType2 = dr.GetString(dr.GetOrdinal("bonus2_skill"))
                bonus = dr.GetInt32(dr.GetOrdinal("bonus1_power"))
                commonname = dr.GetString(dr.GetOrdinal("commonname"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
            End While
        End Using

        imgBack = "http://overpower.ca/cards/misc/op_back.png"
        imgFront = imgFront.Replace("/", "\")
        ImageFront = Image.FromFile(imgFront)
        Image = ImageFront

        commonname = commonname.Substring(0, 20)
    End Sub
End Class