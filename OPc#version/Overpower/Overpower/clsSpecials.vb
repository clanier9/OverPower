Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

<Serializable> Public Class Special : Inherits System.Windows.Forms.PictureBox
    Public ID As Integer
    Public cID As Integer
    Public cName As String
    Public effect As String
    Public meta As String
    Public opd As Boolean
    Public vv As Integer
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

    Public Sub New(ByVal spID As Integer)
        ID = spID
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage

        Dim dt As New OPCardsDataSet.specialsDataTable
        Dim da As New OPCardsDataSetTableAdapters.specialsTableAdapter
        Dim dr As New DataTableReader(dt)

        'find special in database using ID and fill table
        da.FillByID(dt, ID)

        'add special's data
        Using (dr)
            While (dr.Read)
                cName = dr.GetString(dr.GetOrdinal("name_of_card"))
                cID = dr.GetInt32(dr.GetOrdinal("uid"))
                effect = dr.GetString(dr.GetOrdinal("effect"))
                meta = dr.GetString(dr.GetOrdinal("code"))
                opd = dr.GetInt32(dr.GetOrdinal("opd"))
                vv = dr.GetInt32(dr.GetOrdinal("venturevalue"))
                commonname = dr.GetString(dr.GetOrdinal("commonname"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
            End While
        End Using

        imgFront = imgFront.Replace("/", "\")
        ImageFront = Image.FromFile(imgFront)
        imgBack = "http://overpower.ca/cards/misc/op_back.png"
        Image = ImageFront

        If commonname.Contains("(") And ID <> 456 Then
            Dim ca = commonname.ToCharArray
            commonname = ""
            For i = 0 To ca.Length - 1
                If ca(i) <> "(" Then
                    commonname += ca(i)
                Else
                    Exit For
                End If
            Next
        End If
    End Sub
End Class