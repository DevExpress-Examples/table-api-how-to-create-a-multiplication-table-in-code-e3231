using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Commands;
#endregion #usings


namespace Table_API_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ribbonControl1.Minimized = true;
            richEditControl1.CreateNewDocument();
        }

        private void btn_InsertTable_Click(object sender, EventArgs e)
        {
           
            Document doc = richEditControl1.Document;
            doc.BeginUpdate();
            CreateTableStyles(doc);            
            // Insert a table
            Table _table = doc.Tables.Create(doc.Selection.Start, 8, 8, AutoFitBehaviorType.AutoFitToWindow);
            // Start table modification
            _table.BeginUpdate();
            // Insert multiplication values
            IterateCells(_table);
            // Insert a column to the left for row numbering 
            doc.Selection = _table.Rows[1].FirstCell.Range;
            InsertTableColumnToTheLeftCommand cmd = new InsertTableColumnToTheLeftCommand(richEditControl1);
            cmd.Execute();
            _table.ForEachRow(new TableRowProcessorDelegate(InsertRowNumber));
            // Insert a row for column captions
            TableRow column_Captions_Row = _table.Rows.InsertBefore(0);
            InsertColumnNumbers(column_Captions_Row);
            // Insert a header row
            TableRow header_Row = InsertHeader(_table, "Multiplication Table");
            // Finalize formatting
            ApplyBorders(_table);
            ApplyStyles(doc, _table, header_Row);                        
           // Finalize table modification
            _table.EndUpdate();
            doc.EndUpdate();
        }
        #region #createtablestyles
        private void CreateTableStyles(Document doc)
        {
            TableStyle tStyleMain = doc.TableStyles.CreateNew();
            tStyleMain.AllCaps = true;
            tStyleMain.FontName = "Courier New";
            tStyleMain.FontSize = 10;
            tStyleMain.Alignment = ParagraphAlignment.Center; 
            tStyleMain.Name = "MyTableStyle";
            TableCellPropertiesBase tableStyleCellProperties = (TableCellPropertiesBase)(tStyleMain);
            tableStyleCellProperties.CellBackgroundColor = Color.Yellow;
            doc.TableStyles.Add(tStyleMain);

            ParagraphStyle style_Header = doc.ParagraphStyles.CreateNew();
            style_Header.FontName = "Comic Sans";
            style_Header.FontSize = 18;
            style_Header.ForeColor = Color.Blue;
            style_Header.Bold = true;
            style_Header.Name = "MyTableHeaderStyle";
            doc.ParagraphStyles.Add(style_Header);

            ParagraphStyle style_Caption = doc.ParagraphStyles.CreateNew();
            style_Caption.FontName = "Comic Sans";
            style_Caption.FontSize = 14;
            style_Caption.ForeColor = Color.Red;
            style_Caption.Bold = true;
            style_Caption.Name = "MyTableCaptionStyle";
            doc.ParagraphStyles.Add(style_Caption);
        }
        #endregion #createtablestyles

        #region #applystyles
        private static void ApplyStyles(Document doc, Table _table, TableRow header_Row)
        {
            _table.Style = doc.TableStyles["MyTableStyle"];

            foreach (TableRow tr in _table.Rows)
            {
                if (!tr.IsFirst)
                {
                    tr.FirstCell.BackgroundColor = Color.Empty;
                    doc.Paragraphs.Get(tr.FirstCell.ContentRange.Start).Style =
                        doc.ParagraphStyles["MyTableCaptionStyle"];
                }
            }

            foreach (Paragraph p in doc.Paragraphs.Get(header_Row.Next.Range))
            {
                p.Style = doc.ParagraphStyles["MyTableCaptionStyle"];
            }

            foreach (Paragraph p in doc.Paragraphs.Get(header_Row.Range))
            {
                p.Style = doc.ParagraphStyles["MyTableHeaderStyle"];
            }
        }
        #endregion #applystyles
        #region #applyborders
        private static void ApplyBorders(Table _table)
        {
            _table.Borders.Bottom.LineStyle = TableBorderLineStyle.Double;
            _table.Borders.Top.LineStyle = TableBorderLineStyle.Double;
            _table.Borders.Right.LineStyle = TableBorderLineStyle.Double;
            _table.Borders.Left.LineStyle = TableBorderLineStyle.Double;
            _table.Borders.InsideHorizontalBorder.LineThickness = 1;
            _table.Borders.InsideHorizontalBorder.LineStyle = TableBorderLineStyle.Thick;
            _table.Borders.InsideVerticalBorder.LineThickness = 1;
            _table.Borders.InsideVerticalBorder.LineStyle = TableBorderLineStyle.Thick;

            foreach (TableCell _cell in _table.Rows.First.Cells)
            {
                _cell.BackgroundColor = Color.Empty;
            }
        }
        #endregion #applyborders

        #region #celldelegate
        void IterateCells(Table _table) {
            _table.BeginUpdate();
            _table.ForEachCell(new TableCellProcessorDelegate(MakeMultiplicationCell));
            _table.EndUpdate();        
        }
        void MakeMultiplicationCell(TableCell cell, int i, int j)
        {
            richEditControl1.Document.InsertText(cell.Range.Start,
                String.Format("{0}*{1} = {2}", i+2, j+2, (i+2) * (j+2)));
        }
#endregion #celldelegate
        #region #insertcolumnnumbers
        void InsertColumnNumbers(TableRow row)
        {
            foreach (TableCell _cell in row.Cells) {
                if (_cell.Index == 0) continue;
                _cell.BackgroundColor = Color.Empty;
                SubDocument doc = _cell.Range.BeginUpdateDocument();
                DocumentRange range = doc.InsertSingleLineText(_cell.Range.Start, String.Format("{0}", _cell.Index +1));
                range.EndUpdateDocument(doc);
            }
        }
        #endregion #insertcolumnnumbers
        #region #insertheader
        TableRow InsertHeader(Table _table, string caption) {
            _table.BeginUpdate();
            TableRow row = _table.Rows.InsertBefore(0);
            _table.MergeCells(row.FirstCell, row.LastCell);
            SubDocument doc = _table.Range.BeginUpdateDocument();
            DocumentRange header_Range = doc.InsertText(row.FirstCell.Range.Start, caption);
            _table.Range.EndUpdateDocument(doc);            
            _table.EndUpdate();
            return row;
        }
        #endregion #insertheader
        #region #insertrownumber
        void InsertRowNumber(TableRow row, int rowNumber) {
            SubDocument doc = row.FirstCell.Range.BeginUpdateDocument();
            DocumentRange range = doc.InsertText(row.FirstCell.Range.Start, String.Format("{0}", rowNumber + 2));
            range.EndUpdateDocument(doc);        
        }
        #endregion #insertrownumber

    }
}