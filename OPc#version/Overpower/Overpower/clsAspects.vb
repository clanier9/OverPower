Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

<Serializable> Public Class Aspect : Inherits System.Windows.Forms.PictureBox
    Public ID As Integer
    Public effect As String
    Dim opd As Boolean
    Dim imgFront As String
    Dim imgBack As String
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

    Public Sub New()
        Width = 64
        Height = 90
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage
        Location = Cursor.Position
    End Sub

    Public Sub New(ByVal aspid As Integer)
        ID = aspid
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage

        Dim dt As New OPCardsDataSet.aspectDataTable
        Dim da As New OPCardsDataSetTableAdapters.aspectTableAdapter
        Dim dr As New DataTableReader(dt)

        'find aspect in database using ID and fill the table
        da.FillByID(dt, ID)

        'add aspect's data
        Using (dr)
            While (dr.Read)
                effect = dr.GetString(dr.GetOrdinal("effect"))
                opd = dr.GetInt32(dr.GetOrdinal("opd"))
                commonname = dr.GetString(dr.GetOrdinal("commonname"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image_alt"))
            End While
        End Using

        imgFront = imgFront.Replace("/", "\")
        ImageFront = Image.FromFile(imgFront)
        imgBack = "http://overpower.ca/cards/misc/op_back.png"
        Image = ImageFront
    End Sub
End Class
