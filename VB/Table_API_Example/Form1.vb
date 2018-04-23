Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands
#End Region ' #usings


Namespace Table_API_Example
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ribbonControl1.Minimized = True
            richEditControl1.CreateNewDocument()
        End Sub

        Private Sub btn_InsertTable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_InsertTable.Click

            Dim doc As Document = richEditControl1.Document
            doc.BeginUpdate()
            CreateTableStyles(doc)
            ' Insert a table
            Dim _table As Table = doc.Tables.Create(doc.Selection.Start, 8, 8, AutoFitBehaviorType.AutoFitToWindow)
            ' Start table modification
            _table.BeginUpdate()
            ' Insert multiplication values
            IterateCells(_table)
            ' Insert a column to the left for row numbering 
            doc.Selection = _table.Rows(1).FirstCell.Range
            Dim cmd As New InsertTableColumnToTheLeftCommand(richEditControl1)
            cmd.Execute()
            _table.ForEachRow(New TableRowProcessorDelegate(AddressOf InsertRowNumber))
            ' Insert a row for column captions
            Dim column_Captions_Row As TableRow = _table.Rows.InsertBefore(0)
            InsertColumnNumbers(column_Captions_Row)
            ' Insert a header row
            Dim header_Row As TableRow = InsertHeader(_table, "Multiplication Table")
            ' Finalize formatting
            ApplyBorders(_table)
            ApplyStyles(doc, _table, header_Row)
           ' Finalize table modification
            _table.EndUpdate()
            doc.EndUpdate()
        End Sub
        #Region "#createtablestyles"
        Private Sub CreateTableStyles(ByVal doc As Document)
            Dim tStyleMain As TableStyle = doc.TableStyles.CreateNew()
            tStyleMain.AllCaps = True
            tStyleMain.FontName = "Courier New"
            tStyleMain.FontSize = 10
            tStyleMain.Alignment = ParagraphAlignment.Center
            tStyleMain.Name = "MyTableStyle"
            Dim tableStyleCellProperties As TableCellPropertiesBase = CType(tStyleMain, TableCellPropertiesBase)
            tableStyleCellProperties.CellBackgroundColor = Color.Yellow
            doc.TableStyles.Add(tStyleMain)

            Dim style_Header As ParagraphStyle = doc.ParagraphStyles.CreateNew()
            style_Header.FontName = "Comic Sans"
            style_Header.FontSize = 18
            style_Header.ForeColor = Color.Blue
            style_Header.Bold = True
            style_Header.Name = "MyTableHeaderStyle"
            doc.ParagraphStyles.Add(style_Header)

            Dim style_Caption As ParagraphStyle = doc.ParagraphStyles.CreateNew()
            style_Caption.FontName = "Comic Sans"
            style_Caption.FontSize = 14
            style_Caption.ForeColor = Color.Red
            style_Caption.Bold = True
            style_Caption.Name = "MyTableCaptionStyle"
            doc.ParagraphStyles.Add(style_Caption)
        End Sub
        #End Region ' #createtablestyles

        #Region "#applystyles"
        Private Shared Sub ApplyStyles(ByVal doc As Document, ByVal _table As Table, ByVal header_Row As TableRow)
            _table.Style = doc.TableStyles("MyTableStyle")

            For Each tr As TableRow In _table.Rows
                If Not tr.IsFirst Then
                    tr.FirstCell.BackgroundColor = Color.Empty
                    doc.Paragraphs.Get(tr.FirstCell.ContentRange.Start).Style = doc.ParagraphStyles("MyTableCaptionStyle")
                End If
            Next tr

            For Each p As Paragraph In doc.Paragraphs.Get(header_Row.Next.Range)
                p.Style = doc.ParagraphStyles("MyTableCaptionStyle")
            Next p

            For Each p As Paragraph In doc.Paragraphs.Get(header_Row.Range)
                p.Style = doc.ParagraphStyles("MyTableHeaderStyle")
            Next p
        End Sub
        #End Region ' #applystyles
        #Region "#applyborders"
        Private Shared Sub ApplyBorders(ByVal _table As Table)
            _table.Borders.Bottom.LineStyle = TableBorderLineStyle.Double
            _table.Borders.Top.LineStyle = TableBorderLineStyle.Double
            _table.Borders.Right.LineStyle = TableBorderLineStyle.Double
            _table.Borders.Left.LineStyle = TableBorderLineStyle.Double
            _table.Borders.InsideHorizontalBorder.LineThickness = 1
            _table.Borders.InsideHorizontalBorder.LineStyle = TableBorderLineStyle.Thick
            _table.Borders.InsideVerticalBorder.LineThickness = 1
            _table.Borders.InsideVerticalBorder.LineStyle = TableBorderLineStyle.Thick

            For Each _cell As TableCell In _table.Rows.First.Cells
                _cell.BackgroundColor = Color.Empty
            Next _cell
        End Sub
        #End Region ' #applyborders

        #Region "#celldelegate"
        Private Sub IterateCells(ByVal _table As Table)
            _table.BeginUpdate()
            _table.ForEachCell(New TableCellProcessorDelegate(AddressOf MakeMultiplicationCell))
            _table.EndUpdate()
        End Sub
        Private Sub MakeMultiplicationCell(ByVal cell As TableCell, ByVal i As Integer, ByVal j As Integer)
            richEditControl1.Document.InsertText(cell.Range.Start, String.Format("{0}*{1} = {2}", i+2, j+2, (i+2) * (j+2)))
        End Sub
#End Region ' #celldelegate
        #Region "#insertcolumnnumbers"
        Private Sub InsertColumnNumbers(ByVal row As TableRow)
            For Each _cell As TableCell In row.Cells
                If _cell.Index = 0 Then
                    Continue For
                End If
                _cell.BackgroundColor = Color.Empty
                Dim doc As SubDocument = _cell.Range.BeginUpdateDocument()
                Dim range As DocumentRange = doc.InsertSingleLineText(_cell.Range.Start, String.Format("{0}", _cell.Index +1))
                range.EndUpdateDocument(doc)
            Next _cell
        End Sub
        #End Region ' #insertcolumnnumbers
        #Region "#insertheader"
        Private Function InsertHeader(ByVal _table As Table, ByVal caption As String) As TableRow
            _table.BeginUpdate()
            Dim row As TableRow = _table.Rows.InsertBefore(0)
            _table.MergeCells(row.FirstCell, row.LastCell)
            Dim doc As SubDocument = _table.Range.BeginUpdateDocument()
            Dim header_Range As DocumentRange = doc.InsertText(row.FirstCell.Range.Start, caption)
            _table.Range.EndUpdateDocument(doc)
            _table.EndUpdate()
            Return row
        End Function
        #End Region ' #insertheader
        #Region "#insertrownumber"
        Private Sub InsertRowNumber(ByVal row As TableRow, ByVal rowNumber As Integer)
            Dim doc As SubDocument = row.FirstCell.Range.BeginUpdateDocument()
            Dim range As DocumentRange = doc.InsertText(row.FirstCell.Range.Start, String.Format("{0}", rowNumber + 2))
            range.EndUpdateDocument(doc)
        End Sub
        #End Region ' #insertrownumber

    End Class
End Namespace