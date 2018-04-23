Namespace Table_API_Example
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim borderInfo2 As New DevExpress.XtraRichEdit.Model.BorderInfo()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
            Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
            Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
            Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
            Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
            Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
            Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
            Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
            Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
            Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
            Me.changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
            Me.makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
            Me.makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
            Me.toggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
            Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
            Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
            Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
            Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem()
            Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
            Me.changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
            Me.setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
            Me.setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
            Me.setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
            Me.showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
            Me.addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
            Me.removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
            Me.addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
            Me.removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
            Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
            Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
            Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
            Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
            Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            Me.insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            Me.editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
            Me.editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
            Me.insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
            Me.insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
            Me.insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
            Me.changeSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem()
            Me.setNormalSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem()
            Me.setNarrowSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem()
            Me.setModerateSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem()
            Me.setWideSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem()
            Me.changeSectionPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem()
            Me.setPortraitPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem()
            Me.setLandscapePageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem()
            Me.changeSectionPaperKindItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem()
            Me.changeSectionColumnsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem()
            Me.setSectionOneColumnItem1 = New DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem()
            Me.setSectionTwoColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem()
            Me.setSectionThreeColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem()
            Me.showColumnsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem()
            Me.insertBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertBreakItem()
            Me.insertPageBreakItem2 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            Me.insertColumnBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertColumnBreakItem()
            Me.insertSectionBreakNextPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem()
            Me.insertSectionBreakEvenPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem()
            Me.insertSectionBreakOddPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem()
            Me.changeSectionLineNumberingItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem()
            Me.setSectionLineNumberingNoneItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem()
            Me.setSectionLineNumberingContinuousItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem()
            Me.setSectionLineNumberingRestartNewPageItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem()
            Me.setSectionLineNumberingRestartNewSectionItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem()
            Me.toggleParagraphSuppressLineNumbersItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem()
            Me.showLineNumberingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem()
            Me.changeTableCellsShadingItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem()
            Me.changeTableBordersItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBordersItem()
            Me.toggleTableCellsBottomBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem()
            Me.toggleTableCellsTopBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem()
            Me.toggleTableCellsLeftBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem()
            Me.toggleTableCellsRightBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem()
            Me.resetTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem()
            Me.toggleTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem()
            Me.toggleTableCellsOutsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem()
            Me.toggleTableCellsInsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem()
            Me.toggleTableCellsInsideHorizontalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem()
            Me.toggleTableCellsInsideVerticalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem()
            Me.toggleShowTableGridLinesItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem()
            Me.changeTableBorderLineStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem()
            Me.repositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
            Me.changeTableBorderLineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem()
            Me.repositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
            Me.changeTableBorderColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem()
            Me.selectTableElementsItem1 = New DevExpress.XtraRichEdit.UI.SelectTableElementsItem()
            Me.selectTableCellItem1 = New DevExpress.XtraRichEdit.UI.SelectTableCellItem()
            Me.selectTableColumnItem1 = New DevExpress.XtraRichEdit.UI.SelectTableColumnItem()
            Me.selectTableRowItem1 = New DevExpress.XtraRichEdit.UI.SelectTableRowItem()
            Me.selectTableItem1 = New DevExpress.XtraRichEdit.UI.SelectTableItem()
            Me.showTablePropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem()
            Me.deleteTableElementsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableElementsItem()
            Me.showDeleteTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem()
            Me.deleteTableColumnsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem()
            Me.deleteTableRowsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableRowsItem()
            Me.deleteTableItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableItem()
            Me.insertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem()
            Me.insertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem()
            Me.insertTableColumnToLeftItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem()
            Me.insertTableColumnToRightItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem()
            Me.showInsertTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem()
            Me.mergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem()
            Me.showSplitTableCellsForm1 = New DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm()
            Me.splitTableItem1 = New DevExpress.XtraRichEdit.UI.SplitTableItem()
            Me.toggleTableCellsTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem()
            Me.toggleTableCellsTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem()
            Me.toggleTableCellsTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem()
            Me.toggleTableCellsMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem()
            Me.toggleTableCellsMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem()
            Me.toggleTableCellsMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem()
            Me.toggleTableCellsBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem()
            Me.toggleTableCellsBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem()
            Me.toggleTableCellsBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem()
            Me.insertTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem()
            Me.updateTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem()
            Me.addParagraphsToTableOfContentItem1 = New DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem()
            Me.setParagraphHeadingLevelItem1 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem2 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem3 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem4 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem5 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem6 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem7 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem8 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem9 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem10 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
            Me.switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
            Me.switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
            Me.toggleShowHorizontalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem()
            Me.toggleShowVerticalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem()
            Me.zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
            Me.zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
            Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
            Me.tableToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory()
            Me.tableDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableDesignRibbonPage()
            Me.tableStylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup()
            Me.tableDrawBordersRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup()
            Me.tableLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage()
            Me.tableTableRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup()
            Me.tableRowsAndColumnsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup()
            Me.tableMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup()
            Me.tableAlignmentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
            Me.clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
            Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
            Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
            Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
            Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
            Me.insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
            Me.pagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
            Me.tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
            Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
            Me.linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
            Me.headerFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
            Me.symbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
            Me.pageLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage()
            Me.pageSetupRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup()
            Me.referencesRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReferencesRibbonPage()
            Me.tableOfContentsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup()
            Me.viewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ViewRibbonPage()
            Me.documentViewsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup()
            Me.showRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup()
            Me.zoomRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup()
            Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.mailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
            Me.mailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.btn_InsertTable = New System.Windows.Forms.Button()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.EnableToolTips = True
            Me.richEditControl1.Location = New System.Drawing.Point(0, 180)
            Me.richEditControl1.MenuManager = Me.ribbonControl1
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.MailMerge.ViewMergedData = True
            Me.richEditControl1.Size = New System.Drawing.Size(860, 320)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ApplicationButtonText = Nothing
            Me.ribbonControl1.AutoSizeItems = True
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.pasteSpecialItem1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.toggleTextCaseItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.clearFormattingItem1, Me.showFontFormItem1, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.toggleShowWhitespaceItem1, Me.showParagraphFormItem1, Me.changeStyleItem1, Me.findItem1, Me.replaceItem1, Me.insertPageBreakItem1, Me.insertTableItem1, Me.insertPictureItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.insertSymbolItem1, Me.changeSectionPageMarginsItem1, Me.setNormalSectionPageMarginsItem1, Me.setNarrowSectionPageMarginsItem1, Me.setModerateSectionPageMarginsItem1, Me.setWideSectionPageMarginsItem1, Me.changeSectionPageOrientationItem1, Me.setPortraitPageOrientationItem1, Me.setLandscapePageOrientationItem1, Me.changeSectionPaperKindItem1, Me.changeSectionColumnsItem1, Me.setSectionOneColumnItem1, Me.setSectionTwoColumnsItem1, Me.setSectionThreeColumnsItem1, Me.showColumnsSetupFormItem1, Me.insertBreakItem1, Me.insertPageBreakItem2, Me.insertColumnBreakItem1, Me.insertSectionBreakNextPageItem1, Me.insertSectionBreakEvenPageItem1, Me.insertSectionBreakOddPageItem1, Me.changeSectionLineNumberingItem1, Me.setSectionLineNumberingNoneItem1, Me.setSectionLineNumberingContinuousItem1, Me.setSectionLineNumberingRestartNewPageItem1, Me.setSectionLineNumberingRestartNewSectionItem1, Me.toggleParagraphSuppressLineNumbersItem1, Me.showLineNumberingFormItem1, Me.changeTableCellsShadingItem1, Me.changeTableBordersItem1, Me.toggleTableCellsBottomBorderItem1, Me.toggleTableCellsTopBorderItem1, Me.toggleTableCellsLeftBorderItem1, Me.toggleTableCellsRightBorderItem1, Me.resetTableCellsAllBordersItem1, Me.toggleTableCellsAllBordersItem1, Me.toggleTableCellsOutsideBorderItem1, Me.toggleTableCellsInsideBorderItem1, Me.toggleTableCellsInsideHorizontalBorderItem1, Me.toggleTableCellsInsideVerticalBorderItem1, Me.toggleShowTableGridLinesItem1, Me.changeTableBorderLineStyleItem1, Me.changeTableBorderLineWeightItem1, Me.changeTableBorderColorItem1, Me.selectTableElementsItem1, Me.selectTableCellItem1, Me.selectTableColumnItem1, Me.selectTableRowItem1, Me.selectTableItem1, Me.showTablePropertiesFormItem1, Me.deleteTableElementsItem1, Me.showDeleteTableCellsFormItem1, Me.deleteTableColumnsItem1, Me.deleteTableRowsItem1, Me.deleteTableItem1, Me.insertTableRowAboveItem1, Me.insertTableRowBelowItem1, Me.insertTableColumnToLeftItem1, Me.insertTableColumnToRightItem1, Me.showInsertTableCellsFormItem1, Me.mergeTableCellsItem1, Me.showSplitTableCellsForm1, Me.splitTableItem1, Me.toggleTableCellsTopLeftAlignmentItem1, Me.toggleTableCellsTopCenterAlignmentItem1, Me.toggleTableCellsTopRightAlignmentItem1, Me.toggleTableCellsMiddleLeftAlignmentItem1, Me.toggleTableCellsMiddleCenterAlignmentItem1, Me.toggleTableCellsMiddleRightAlignmentItem1, Me.toggleTableCellsBottomLeftAlignmentItem1, Me.toggleTableCellsBottomCenterAlignmentItem1, Me.toggleTableCellsBottomRightAlignmentItem1, Me.insertTableOfContentsItem1, Me.updateTableOfContentsItem1, Me.addParagraphsToTableOfContentItem1, Me.setParagraphHeadingLevelItem1, Me.setParagraphHeadingLevelItem2, Me.setParagraphHeadingLevelItem3, Me.setParagraphHeadingLevelItem4, Me.setParagraphHeadingLevelItem5, Me.setParagraphHeadingLevelItem6, Me.setParagraphHeadingLevelItem7, Me.setParagraphHeadingLevelItem8, Me.setParagraphHeadingLevelItem9, Me.setParagraphHeadingLevelItem10, Me.switchToSimpleViewItem1, Me.switchToDraftViewItem1, Me.switchToPrintLayoutViewItem1, Me.toggleShowHorizontalRulerItem1, Me.toggleShowVerticalRulerItem1, Me.zoomOutItem1, Me.zoomInItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 39)
            Me.ribbonControl1.MaxItemId = 163
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.tableToolsRibbonPageCategory1})
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.homeRibbonPage1, Me.insertRibbonPage1, Me.pageLayoutRibbonPage1, Me.referencesRibbonPage1, Me.viewRibbonPage1, Me.fileRibbonPage1, Me.mailingsRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1, Me.repositoryItemBorderLineStyle1, Me.repositoryItemBorderLineWeight1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.ribbonControl1.Size = New System.Drawing.Size(860, 141)
            ' 
            ' cutItem1
            ' 
            Me.cutItem1.Glyph = (DirectCast(resources.GetObject("cutItem1.Glyph"), System.Drawing.Image))
            Me.cutItem1.Id = 1
            Me.cutItem1.LargeGlyph = (DirectCast(resources.GetObject("cutItem1.LargeGlyph"), System.Drawing.Image))
            Me.cutItem1.Name = "cutItem1"
            ' 
            ' copyItem1
            ' 
            Me.copyItem1.Glyph = (DirectCast(resources.GetObject("copyItem1.Glyph"), System.Drawing.Image))
            Me.copyItem1.Id = 2
            Me.copyItem1.LargeGlyph = (DirectCast(resources.GetObject("copyItem1.LargeGlyph"), System.Drawing.Image))
            Me.copyItem1.Name = "copyItem1"
            ' 
            ' pasteItem1
            ' 
            Me.pasteItem1.Glyph = (DirectCast(resources.GetObject("pasteItem1.Glyph"), System.Drawing.Image))
            Me.pasteItem1.Id = 3
            Me.pasteItem1.LargeGlyph = (DirectCast(resources.GetObject("pasteItem1.LargeGlyph"), System.Drawing.Image))
            Me.pasteItem1.Name = "pasteItem1"
            ' 
            ' pasteSpecialItem1
            ' 
            Me.pasteSpecialItem1.Glyph = (DirectCast(resources.GetObject("pasteSpecialItem1.Glyph"), System.Drawing.Image))
            Me.pasteSpecialItem1.Id = 4
            Me.pasteSpecialItem1.LargeGlyph = (DirectCast(resources.GetObject("pasteSpecialItem1.LargeGlyph"), System.Drawing.Image))
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            ' 
            ' changeFontNameItem1
            ' 
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 5
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' changeFontSizeItem1
            ' 
            Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
            Me.changeFontSizeItem1.Id = 6
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            ' 
            ' repositoryItemRichEditFontSizeEdit1
            ' 
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl1
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            ' 
            ' changeFontColorItem1
            ' 
            Me.changeFontColorItem1.Glyph = (DirectCast(resources.GetObject("changeFontColorItem1.Glyph"), System.Drawing.Image))
            Me.changeFontColorItem1.Id = 7
            Me.changeFontColorItem1.LargeGlyph = (DirectCast(resources.GetObject("changeFontColorItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            ' 
            ' changeFontBackColorItem1
            ' 
            Me.changeFontBackColorItem1.Glyph = (DirectCast(resources.GetObject("changeFontBackColorItem1.Glyph"), System.Drawing.Image))
            Me.changeFontBackColorItem1.Id = 8
            Me.changeFontBackColorItem1.LargeGlyph = (DirectCast(resources.GetObject("changeFontBackColorItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            ' 
            ' toggleFontBoldItem1
            ' 
            Me.toggleFontBoldItem1.Glyph = (DirectCast(resources.GetObject("toggleFontBoldItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontBoldItem1.Id = 9
            Me.toggleFontBoldItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleFontBoldItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            ' 
            ' toggleFontItalicItem1
            ' 
            Me.toggleFontItalicItem1.Glyph = (DirectCast(resources.GetObject("toggleFontItalicItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontItalicItem1.Id = 10
            Me.toggleFontItalicItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleFontItalicItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            ' 
            ' toggleFontUnderlineItem1
            ' 
            Me.toggleFontUnderlineItem1.Glyph = (DirectCast(resources.GetObject("toggleFontUnderlineItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontUnderlineItem1.Id = 11
            Me.toggleFontUnderlineItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleFontUnderlineItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            ' 
            ' toggleFontDoubleUnderlineItem1
            ' 
            Me.toggleFontDoubleUnderlineItem1.Glyph = (DirectCast(resources.GetObject("toggleFontDoubleUnderlineItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontDoubleUnderlineItem1.Id = 12
            Me.toggleFontDoubleUnderlineItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleFontDoubleUnderlineItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            ' 
            ' toggleFontStrikeoutItem1
            ' 
            Me.toggleFontStrikeoutItem1.Glyph = (DirectCast(resources.GetObject("toggleFontStrikeoutItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontStrikeoutItem1.Id = 13
            Me.toggleFontStrikeoutItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleFontStrikeoutItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            ' 
            ' toggleFontDoubleStrikeoutItem1
            ' 
            Me.toggleFontDoubleStrikeoutItem1.Glyph = (DirectCast(resources.GetObject("toggleFontDoubleStrikeoutItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontDoubleStrikeoutItem1.Id = 14
            Me.toggleFontDoubleStrikeoutItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleFontDoubleStrikeoutItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            ' 
            ' toggleFontSuperscriptItem1
            ' 
            Me.toggleFontSuperscriptItem1.Glyph = (DirectCast(resources.GetObject("toggleFontSuperscriptItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontSuperscriptItem1.Id = 15
            Me.toggleFontSuperscriptItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleFontSuperscriptItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            ' 
            ' toggleFontSubscriptItem1
            ' 
            Me.toggleFontSubscriptItem1.Glyph = (DirectCast(resources.GetObject("toggleFontSubscriptItem1.Glyph"), System.Drawing.Image))
            Me.toggleFontSubscriptItem1.Id = 16
            Me.toggleFontSubscriptItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleFontSubscriptItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            ' 
            ' changeTextCaseItem1
            ' 
            Me.changeTextCaseItem1.Glyph = (DirectCast(resources.GetObject("changeTextCaseItem1.Glyph"), System.Drawing.Image))
            Me.changeTextCaseItem1.Id = 17
            Me.changeTextCaseItem1.LargeGlyph = (DirectCast(resources.GetObject("changeTextCaseItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1) _
            })
            Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
            ' 
            ' makeTextUpperCaseItem1
            ' 
            Me.makeTextUpperCaseItem1.Id = 18
            Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            ' 
            ' makeTextLowerCaseItem1
            ' 
            Me.makeTextLowerCaseItem1.Id = 19
            Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
            ' 
            ' toggleTextCaseItem1
            ' 
            Me.toggleTextCaseItem1.Id = 20
            Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
            ' 
            ' fontSizeIncreaseItem1
            ' 
            Me.fontSizeIncreaseItem1.Glyph = (DirectCast(resources.GetObject("fontSizeIncreaseItem1.Glyph"), System.Drawing.Image))
            Me.fontSizeIncreaseItem1.Id = 21
            Me.fontSizeIncreaseItem1.LargeGlyph = (DirectCast(resources.GetObject("fontSizeIncreaseItem1.LargeGlyph"), System.Drawing.Image))
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            ' 
            ' fontSizeDecreaseItem1
            ' 
            Me.fontSizeDecreaseItem1.Glyph = (DirectCast(resources.GetObject("fontSizeDecreaseItem1.Glyph"), System.Drawing.Image))
            Me.fontSizeDecreaseItem1.Id = 22
            Me.fontSizeDecreaseItem1.LargeGlyph = (DirectCast(resources.GetObject("fontSizeDecreaseItem1.LargeGlyph"), System.Drawing.Image))
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            ' 
            ' clearFormattingItem1
            ' 
            Me.clearFormattingItem1.Glyph = (DirectCast(resources.GetObject("clearFormattingItem1.Glyph"), System.Drawing.Image))
            Me.clearFormattingItem1.Id = 23
            Me.clearFormattingItem1.LargeGlyph = (DirectCast(resources.GetObject("clearFormattingItem1.LargeGlyph"), System.Drawing.Image))
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            ' 
            ' showFontFormItem1
            ' 
            Me.showFontFormItem1.Glyph = (DirectCast(resources.GetObject("showFontFormItem1.Glyph"), System.Drawing.Image))
            Me.showFontFormItem1.Id = 24
            Me.showFontFormItem1.LargeGlyph = (DirectCast(resources.GetObject("showFontFormItem1.LargeGlyph"), System.Drawing.Image))
            Me.showFontFormItem1.Name = "showFontFormItem1"
            ' 
            ' toggleParagraphAlignmentLeftItem1
            ' 
            Me.toggleParagraphAlignmentLeftItem1.Glyph = (DirectCast(resources.GetObject("toggleParagraphAlignmentLeftItem1.Glyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentLeftItem1.Id = 25
            Me.toggleParagraphAlignmentLeftItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleParagraphAlignmentLeftItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            ' 
            ' toggleParagraphAlignmentCenterItem1
            ' 
            Me.toggleParagraphAlignmentCenterItem1.Glyph = (DirectCast(resources.GetObject("toggleParagraphAlignmentCenterItem1.Glyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentCenterItem1.Id = 26
            Me.toggleParagraphAlignmentCenterItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleParagraphAlignmentCenterItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            ' 
            ' toggleParagraphAlignmentRightItem1
            ' 
            Me.toggleParagraphAlignmentRightItem1.Glyph = (DirectCast(resources.GetObject("toggleParagraphAlignmentRightItem1.Glyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentRightItem1.Id = 27
            Me.toggleParagraphAlignmentRightItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleParagraphAlignmentRightItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            ' 
            ' toggleParagraphAlignmentJustifyItem1
            ' 
            Me.toggleParagraphAlignmentJustifyItem1.Glyph = (DirectCast(resources.GetObject("toggleParagraphAlignmentJustifyItem1.Glyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentJustifyItem1.Id = 28
            Me.toggleParagraphAlignmentJustifyItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleParagraphAlignmentJustifyItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            ' 
            ' changeParagraphLineSpacingItem1
            ' 
            Me.changeParagraphLineSpacingItem1.Glyph = (DirectCast(resources.GetObject("changeParagraphLineSpacingItem1.Glyph"), System.Drawing.Image))
            Me.changeParagraphLineSpacingItem1.Id = 29
            Me.changeParagraphLineSpacingItem1.LargeGlyph = (DirectCast(resources.GetObject("changeParagraphLineSpacingItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1) _
            })
            Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            ' 
            ' setSingleParagraphSpacingItem1
            ' 
            Me.setSingleParagraphSpacingItem1.Id = 30
            Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            ' 
            ' setSesquialteralParagraphSpacingItem1
            ' 
            Me.setSesquialteralParagraphSpacingItem1.Id = 31
            Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            ' 
            ' setDoubleParagraphSpacingItem1
            ' 
            Me.setDoubleParagraphSpacingItem1.Id = 32
            Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            ' 
            ' showLineSpacingFormItem1
            ' 
            Me.showLineSpacingFormItem1.Id = 33
            Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            ' 
            ' addSpacingBeforeParagraphItem1
            ' 
            Me.addSpacingBeforeParagraphItem1.Id = 34
            Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            ' 
            ' removeSpacingBeforeParagraphItem1
            ' 
            Me.removeSpacingBeforeParagraphItem1.Id = 35
            Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            ' 
            ' addSpacingAfterParagraphItem1
            ' 
            Me.addSpacingAfterParagraphItem1.Id = 36
            Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            ' 
            ' removeSpacingAfterParagraphItem1
            ' 
            Me.removeSpacingAfterParagraphItem1.Id = 37
            Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            ' 
            ' toggleBulletedListItem1
            ' 
            Me.toggleBulletedListItem1.Glyph = (DirectCast(resources.GetObject("toggleBulletedListItem1.Glyph"), System.Drawing.Image))
            Me.toggleBulletedListItem1.Id = 38
            Me.toggleBulletedListItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleBulletedListItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            ' 
            ' toggleNumberingListItem1
            ' 
            Me.toggleNumberingListItem1.Glyph = (DirectCast(resources.GetObject("toggleNumberingListItem1.Glyph"), System.Drawing.Image))
            Me.toggleNumberingListItem1.Id = 39
            Me.toggleNumberingListItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleNumberingListItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            ' 
            ' toggleMultiLevelListItem1
            ' 
            Me.toggleMultiLevelListItem1.Glyph = (DirectCast(resources.GetObject("toggleMultiLevelListItem1.Glyph"), System.Drawing.Image))
            Me.toggleMultiLevelListItem1.Id = 40
            Me.toggleMultiLevelListItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleMultiLevelListItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            ' 
            ' decreaseIndentItem1
            ' 
            Me.decreaseIndentItem1.Glyph = (DirectCast(resources.GetObject("decreaseIndentItem1.Glyph"), System.Drawing.Image))
            Me.decreaseIndentItem1.Id = 41
            Me.decreaseIndentItem1.LargeGlyph = (DirectCast(resources.GetObject("decreaseIndentItem1.LargeGlyph"), System.Drawing.Image))
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            ' 
            ' increaseIndentItem1
            ' 
            Me.increaseIndentItem1.Glyph = (DirectCast(resources.GetObject("increaseIndentItem1.Glyph"), System.Drawing.Image))
            Me.increaseIndentItem1.Id = 42
            Me.increaseIndentItem1.LargeGlyph = (DirectCast(resources.GetObject("increaseIndentItem1.LargeGlyph"), System.Drawing.Image))
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            ' 
            ' toggleShowWhitespaceItem1
            ' 
            Me.toggleShowWhitespaceItem1.Glyph = (DirectCast(resources.GetObject("toggleShowWhitespaceItem1.Glyph"), System.Drawing.Image))
            Me.toggleShowWhitespaceItem1.Id = 43
            Me.toggleShowWhitespaceItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleShowWhitespaceItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            ' 
            ' showParagraphFormItem1
            ' 
            Me.showParagraphFormItem1.Glyph = (DirectCast(resources.GetObject("showParagraphFormItem1.Glyph"), System.Drawing.Image))
            Me.showParagraphFormItem1.Id = 44
            Me.showParagraphFormItem1.LargeGlyph = (DirectCast(resources.GetObject("showParagraphFormItem1.LargeGlyph"), System.Drawing.Image))
            Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
            ' 
            ' changeStyleItem1
            ' 
            Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
            Me.changeStyleItem1.Id = 45
            Me.changeStyleItem1.Name = "changeStyleItem1"
            ' 
            ' repositoryItemRichEditStyleEdit1
            ' 
            Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
            Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl1
            Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
            ' 
            ' findItem1
            ' 
            Me.findItem1.Glyph = (DirectCast(resources.GetObject("findItem1.Glyph"), System.Drawing.Image))
            Me.findItem1.Id = 46
            Me.findItem1.LargeGlyph = (DirectCast(resources.GetObject("findItem1.LargeGlyph"), System.Drawing.Image))
            Me.findItem1.Name = "findItem1"
            ' 
            ' replaceItem1
            ' 
            Me.replaceItem1.Glyph = (DirectCast(resources.GetObject("replaceItem1.Glyph"), System.Drawing.Image))
            Me.replaceItem1.Id = 47
            Me.replaceItem1.LargeGlyph = (DirectCast(resources.GetObject("replaceItem1.LargeGlyph"), System.Drawing.Image))
            Me.replaceItem1.Name = "replaceItem1"
            ' 
            ' insertPageBreakItem1
            ' 
            Me.insertPageBreakItem1.Glyph = (DirectCast(resources.GetObject("insertPageBreakItem1.Glyph"), System.Drawing.Image))
            Me.insertPageBreakItem1.Id = 48
            Me.insertPageBreakItem1.LargeGlyph = (DirectCast(resources.GetObject("insertPageBreakItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
            ' 
            ' insertTableItem1
            ' 
            Me.insertTableItem1.Glyph = (DirectCast(resources.GetObject("insertTableItem1.Glyph"), System.Drawing.Image))
            Me.insertTableItem1.Id = 49
            Me.insertTableItem1.LargeGlyph = (DirectCast(resources.GetObject("insertTableItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertTableItem1.Name = "insertTableItem1"
            ' 
            ' insertPictureItem1
            ' 
            Me.insertPictureItem1.Glyph = (DirectCast(resources.GetObject("insertPictureItem1.Glyph"), System.Drawing.Image))
            Me.insertPictureItem1.Id = 50
            Me.insertPictureItem1.LargeGlyph = (DirectCast(resources.GetObject("insertPictureItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertPictureItem1.Name = "insertPictureItem1"
            ' 
            ' insertBookmarkItem1
            ' 
            Me.insertBookmarkItem1.Glyph = (DirectCast(resources.GetObject("insertBookmarkItem1.Glyph"), System.Drawing.Image))
            Me.insertBookmarkItem1.Id = 51
            Me.insertBookmarkItem1.LargeGlyph = (DirectCast(resources.GetObject("insertBookmarkItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
            ' 
            ' insertHyperlinkItem1
            ' 
            Me.insertHyperlinkItem1.Glyph = (DirectCast(resources.GetObject("insertHyperlinkItem1.Glyph"), System.Drawing.Image))
            Me.insertHyperlinkItem1.Id = 52
            Me.insertHyperlinkItem1.LargeGlyph = (DirectCast(resources.GetObject("insertHyperlinkItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            ' 
            ' editPageHeaderItem1
            ' 
            Me.editPageHeaderItem1.Glyph = (DirectCast(resources.GetObject("editPageHeaderItem1.Glyph"), System.Drawing.Image))
            Me.editPageHeaderItem1.Id = 53
            Me.editPageHeaderItem1.LargeGlyph = (DirectCast(resources.GetObject("editPageHeaderItem1.LargeGlyph"), System.Drawing.Image))
            Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
            ' 
            ' editPageFooterItem1
            ' 
            Me.editPageFooterItem1.Glyph = (DirectCast(resources.GetObject("editPageFooterItem1.Glyph"), System.Drawing.Image))
            Me.editPageFooterItem1.Id = 54
            Me.editPageFooterItem1.LargeGlyph = (DirectCast(resources.GetObject("editPageFooterItem1.LargeGlyph"), System.Drawing.Image))
            Me.editPageFooterItem1.Name = "editPageFooterItem1"
            ' 
            ' insertPageNumberItem1
            ' 
            Me.insertPageNumberItem1.Glyph = (DirectCast(resources.GetObject("insertPageNumberItem1.Glyph"), System.Drawing.Image))
            Me.insertPageNumberItem1.Id = 55
            Me.insertPageNumberItem1.LargeGlyph = (DirectCast(resources.GetObject("insertPageNumberItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
            ' 
            ' insertPageCountItem1
            ' 
            Me.insertPageCountItem1.Glyph = (DirectCast(resources.GetObject("insertPageCountItem1.Glyph"), System.Drawing.Image))
            Me.insertPageCountItem1.Id = 56
            Me.insertPageCountItem1.LargeGlyph = (DirectCast(resources.GetObject("insertPageCountItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertPageCountItem1.Name = "insertPageCountItem1"
            ' 
            ' insertSymbolItem1
            ' 
            Me.insertSymbolItem1.Glyph = (DirectCast(resources.GetObject("insertSymbolItem1.Glyph"), System.Drawing.Image))
            Me.insertSymbolItem1.Id = 57
            Me.insertSymbolItem1.LargeGlyph = (DirectCast(resources.GetObject("insertSymbolItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
            ' 
            ' changeSectionPageMarginsItem1
            ' 
            Me.changeSectionPageMarginsItem1.Glyph = (DirectCast(resources.GetObject("changeSectionPageMarginsItem1.Glyph"), System.Drawing.Image))
            Me.changeSectionPageMarginsItem1.Id = 58
            Me.changeSectionPageMarginsItem1.LargeGlyph = (DirectCast(resources.GetObject("changeSectionPageMarginsItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setNormalSectionPageMarginsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setNarrowSectionPageMarginsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setModerateSectionPageMarginsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setWideSectionPageMarginsItem1) _
            })
            Me.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1"
            ' 
            ' setNormalSectionPageMarginsItem1
            ' 
            Me.setNormalSectionPageMarginsItem1.Glyph = (DirectCast(resources.GetObject("setNormalSectionPageMarginsItem1.Glyph"), System.Drawing.Image))
            Me.setNormalSectionPageMarginsItem1.Id = 59
            Me.setNormalSectionPageMarginsItem1.LargeGlyph = (DirectCast(resources.GetObject("setNormalSectionPageMarginsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1"
            ' 
            ' setNarrowSectionPageMarginsItem1
            ' 
            Me.setNarrowSectionPageMarginsItem1.Glyph = (DirectCast(resources.GetObject("setNarrowSectionPageMarginsItem1.Glyph"), System.Drawing.Image))
            Me.setNarrowSectionPageMarginsItem1.Id = 60
            Me.setNarrowSectionPageMarginsItem1.LargeGlyph = (DirectCast(resources.GetObject("setNarrowSectionPageMarginsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1"
            ' 
            ' setModerateSectionPageMarginsItem1
            ' 
            Me.setModerateSectionPageMarginsItem1.Glyph = (DirectCast(resources.GetObject("setModerateSectionPageMarginsItem1.Glyph"), System.Drawing.Image))
            Me.setModerateSectionPageMarginsItem1.Id = 61
            Me.setModerateSectionPageMarginsItem1.LargeGlyph = (DirectCast(resources.GetObject("setModerateSectionPageMarginsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1"
            ' 
            ' setWideSectionPageMarginsItem1
            ' 
            Me.setWideSectionPageMarginsItem1.Glyph = (DirectCast(resources.GetObject("setWideSectionPageMarginsItem1.Glyph"), System.Drawing.Image))
            Me.setWideSectionPageMarginsItem1.Id = 62
            Me.setWideSectionPageMarginsItem1.LargeGlyph = (DirectCast(resources.GetObject("setWideSectionPageMarginsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1"
            ' 
            ' changeSectionPageOrientationItem1
            ' 
            Me.changeSectionPageOrientationItem1.Glyph = (DirectCast(resources.GetObject("changeSectionPageOrientationItem1.Glyph"), System.Drawing.Image))
            Me.changeSectionPageOrientationItem1.Id = 63
            Me.changeSectionPageOrientationItem1.LargeGlyph = (DirectCast(resources.GetObject("changeSectionPageOrientationItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setPortraitPageOrientationItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setLandscapePageOrientationItem1) _
            })
            Me.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1"
            ' 
            ' setPortraitPageOrientationItem1
            ' 
            Me.setPortraitPageOrientationItem1.Id = 64
            Me.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1"
            ' 
            ' setLandscapePageOrientationItem1
            ' 
            Me.setLandscapePageOrientationItem1.Id = 65
            Me.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1"
            ' 
            ' changeSectionPaperKindItem1
            ' 
            Me.changeSectionPaperKindItem1.Glyph = (DirectCast(resources.GetObject("changeSectionPaperKindItem1.Glyph"), System.Drawing.Image))
            Me.changeSectionPaperKindItem1.Id = 66
            Me.changeSectionPaperKindItem1.LargeGlyph = (DirectCast(resources.GetObject("changeSectionPaperKindItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1"
            ' 
            ' changeSectionColumnsItem1
            ' 
            Me.changeSectionColumnsItem1.Glyph = (DirectCast(resources.GetObject("changeSectionColumnsItem1.Glyph"), System.Drawing.Image))
            Me.changeSectionColumnsItem1.Id = 67
            Me.changeSectionColumnsItem1.LargeGlyph = (DirectCast(resources.GetObject("changeSectionColumnsItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionOneColumnItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionTwoColumnsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionThreeColumnsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showColumnsSetupFormItem1) _
            })
            Me.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1"
            ' 
            ' setSectionOneColumnItem1
            ' 
            Me.setSectionOneColumnItem1.Glyph = (DirectCast(resources.GetObject("setSectionOneColumnItem1.Glyph"), System.Drawing.Image))
            Me.setSectionOneColumnItem1.Id = 68
            Me.setSectionOneColumnItem1.LargeGlyph = (DirectCast(resources.GetObject("setSectionOneColumnItem1.LargeGlyph"), System.Drawing.Image))
            Me.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1"
            ' 
            ' setSectionTwoColumnsItem1
            ' 
            Me.setSectionTwoColumnsItem1.Glyph = (DirectCast(resources.GetObject("setSectionTwoColumnsItem1.Glyph"), System.Drawing.Image))
            Me.setSectionTwoColumnsItem1.Id = 69
            Me.setSectionTwoColumnsItem1.LargeGlyph = (DirectCast(resources.GetObject("setSectionTwoColumnsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1"
            ' 
            ' setSectionThreeColumnsItem1
            ' 
            Me.setSectionThreeColumnsItem1.Glyph = (DirectCast(resources.GetObject("setSectionThreeColumnsItem1.Glyph"), System.Drawing.Image))
            Me.setSectionThreeColumnsItem1.Id = 70
            Me.setSectionThreeColumnsItem1.LargeGlyph = (DirectCast(resources.GetObject("setSectionThreeColumnsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1"
            ' 
            ' showColumnsSetupFormItem1
            ' 
            Me.showColumnsSetupFormItem1.Glyph = (DirectCast(resources.GetObject("showColumnsSetupFormItem1.Glyph"), System.Drawing.Image))
            Me.showColumnsSetupFormItem1.Id = 71
            Me.showColumnsSetupFormItem1.LargeGlyph = (DirectCast(resources.GetObject("showColumnsSetupFormItem1.LargeGlyph"), System.Drawing.Image))
            Me.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1"
            ' 
            ' insertBreakItem1
            ' 
            Me.insertBreakItem1.Glyph = (DirectCast(resources.GetObject("insertBreakItem1.Glyph"), System.Drawing.Image))
            Me.insertBreakItem1.Id = 72
            Me.insertBreakItem1.LargeGlyph = (DirectCast(resources.GetObject("insertBreakItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertPageBreakItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertColumnBreakItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakNextPageItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakEvenPageItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakOddPageItem1) _
            })
            Me.insertBreakItem1.Name = "insertBreakItem1"
            ' 
            ' insertPageBreakItem2
            ' 
            Me.insertPageBreakItem2.Glyph = (DirectCast(resources.GetObject("insertPageBreakItem2.Glyph"), System.Drawing.Image))
            Me.insertPageBreakItem2.Id = 73
            Me.insertPageBreakItem2.LargeGlyph = (DirectCast(resources.GetObject("insertPageBreakItem2.LargeGlyph"), System.Drawing.Image))
            Me.insertPageBreakItem2.Name = "insertPageBreakItem2"
            ' 
            ' insertColumnBreakItem1
            ' 
            Me.insertColumnBreakItem1.Glyph = (DirectCast(resources.GetObject("insertColumnBreakItem1.Glyph"), System.Drawing.Image))
            Me.insertColumnBreakItem1.Id = 74
            Me.insertColumnBreakItem1.LargeGlyph = (DirectCast(resources.GetObject("insertColumnBreakItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertColumnBreakItem1.Name = "insertColumnBreakItem1"
            ' 
            ' insertSectionBreakNextPageItem1
            ' 
            Me.insertSectionBreakNextPageItem1.Glyph = (DirectCast(resources.GetObject("insertSectionBreakNextPageItem1.Glyph"), System.Drawing.Image))
            Me.insertSectionBreakNextPageItem1.Id = 75
            Me.insertSectionBreakNextPageItem1.LargeGlyph = (DirectCast(resources.GetObject("insertSectionBreakNextPageItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1"
            ' 
            ' insertSectionBreakEvenPageItem1
            ' 
            Me.insertSectionBreakEvenPageItem1.Glyph = (DirectCast(resources.GetObject("insertSectionBreakEvenPageItem1.Glyph"), System.Drawing.Image))
            Me.insertSectionBreakEvenPageItem1.Id = 76
            Me.insertSectionBreakEvenPageItem1.LargeGlyph = (DirectCast(resources.GetObject("insertSectionBreakEvenPageItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1"
            ' 
            ' insertSectionBreakOddPageItem1
            ' 
            Me.insertSectionBreakOddPageItem1.Glyph = (DirectCast(resources.GetObject("insertSectionBreakOddPageItem1.Glyph"), System.Drawing.Image))
            Me.insertSectionBreakOddPageItem1.Id = 77
            Me.insertSectionBreakOddPageItem1.LargeGlyph = (DirectCast(resources.GetObject("insertSectionBreakOddPageItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1"
            ' 
            ' changeSectionLineNumberingItem1
            ' 
            Me.changeSectionLineNumberingItem1.Glyph = (DirectCast(resources.GetObject("changeSectionLineNumberingItem1.Glyph"), System.Drawing.Image))
            Me.changeSectionLineNumberingItem1.Id = 78
            Me.changeSectionLineNumberingItem1.LargeGlyph = (DirectCast(resources.GetObject("changeSectionLineNumberingItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingNoneItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingContinuousItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewPageItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewSectionItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphSuppressLineNumbersItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showLineNumberingFormItem1) _
            })
            Me.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1"
            ' 
            ' setSectionLineNumberingNoneItem1
            ' 
            Me.setSectionLineNumberingNoneItem1.Id = 79
            Me.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1"
            ' 
            ' setSectionLineNumberingContinuousItem1
            ' 
            Me.setSectionLineNumberingContinuousItem1.Id = 80
            Me.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1"
            ' 
            ' setSectionLineNumberingRestartNewPageItem1
            ' 
            Me.setSectionLineNumberingRestartNewPageItem1.Id = 81
            Me.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1"
            ' 
            ' setSectionLineNumberingRestartNewSectionItem1
            ' 
            Me.setSectionLineNumberingRestartNewSectionItem1.Id = 82
            Me.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1"
            ' 
            ' toggleParagraphSuppressLineNumbersItem1
            ' 
            Me.toggleParagraphSuppressLineNumbersItem1.Id = 83
            Me.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1"
            ' 
            ' showLineNumberingFormItem1
            ' 
            Me.showLineNumberingFormItem1.Id = 84
            Me.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1"
            ' 
            ' changeTableCellsShadingItem1
            ' 
            Me.changeTableCellsShadingItem1.Glyph = (DirectCast(resources.GetObject("changeTableCellsShadingItem1.Glyph"), System.Drawing.Image))
            Me.changeTableCellsShadingItem1.Id = 85
            Me.changeTableCellsShadingItem1.LargeGlyph = (DirectCast(resources.GetObject("changeTableCellsShadingItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
            ' 
            ' changeTableBordersItem1
            ' 
            Me.changeTableBordersItem1.Glyph = (DirectCast(resources.GetObject("changeTableBordersItem1.Glyph"), System.Drawing.Image))
            Me.changeTableBordersItem1.Id = 86
            Me.changeTableBordersItem1.LargeGlyph = (DirectCast(resources.GetObject("changeTableBordersItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsLeftBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsRightBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.resetTableCellsAllBordersItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsAllBordersItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsOutsideBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideHorizontalBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideVerticalBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleShowTableGridLinesItem1) _
            })
            Me.changeTableBordersItem1.Name = "changeTableBordersItem1"
            ' 
            ' toggleTableCellsBottomBorderItem1
            ' 
            Me.toggleTableCellsBottomBorderItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsBottomBorderItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsBottomBorderItem1.Id = 87
            Me.toggleTableCellsBottomBorderItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsBottomBorderItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
            ' 
            ' toggleTableCellsTopBorderItem1
            ' 
            Me.toggleTableCellsTopBorderItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsTopBorderItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsTopBorderItem1.Id = 88
            Me.toggleTableCellsTopBorderItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsTopBorderItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
            ' 
            ' toggleTableCellsLeftBorderItem1
            ' 
            Me.toggleTableCellsLeftBorderItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsLeftBorderItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsLeftBorderItem1.Id = 89
            Me.toggleTableCellsLeftBorderItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsLeftBorderItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
            ' 
            ' toggleTableCellsRightBorderItem1
            ' 
            Me.toggleTableCellsRightBorderItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsRightBorderItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsRightBorderItem1.Id = 90
            Me.toggleTableCellsRightBorderItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsRightBorderItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
            ' 
            ' resetTableCellsAllBordersItem1
            ' 
            Me.resetTableCellsAllBordersItem1.Glyph = (DirectCast(resources.GetObject("resetTableCellsAllBordersItem1.Glyph"), System.Drawing.Image))
            Me.resetTableCellsAllBordersItem1.Id = 91
            Me.resetTableCellsAllBordersItem1.LargeGlyph = (DirectCast(resources.GetObject("resetTableCellsAllBordersItem1.LargeGlyph"), System.Drawing.Image))
            Me.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsAllBordersItem1
            ' 
            Me.toggleTableCellsAllBordersItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsAllBordersItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsAllBordersItem1.Id = 92
            Me.toggleTableCellsAllBordersItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsAllBordersItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsOutsideBorderItem1
            ' 
            Me.toggleTableCellsOutsideBorderItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsOutsideBorderItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsOutsideBorderItem1.Id = 93
            Me.toggleTableCellsOutsideBorderItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsOutsideBorderItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
            ' 
            ' toggleTableCellsInsideBorderItem1
            ' 
            Me.toggleTableCellsInsideBorderItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsInsideBorderItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsInsideBorderItem1.Id = 94
            Me.toggleTableCellsInsideBorderItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsInsideBorderItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
            ' 
            ' toggleTableCellsInsideHorizontalBorderItem1
            ' 
            Me.toggleTableCellsInsideHorizontalBorderItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsInsideHorizontalBorderItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsInsideHorizontalBorderItem1.Id = 95
            Me.toggleTableCellsInsideHorizontalBorderItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsInsideHorizontalBorderItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
            ' 
            ' toggleTableCellsInsideVerticalBorderItem1
            ' 
            Me.toggleTableCellsInsideVerticalBorderItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsInsideVerticalBorderItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsInsideVerticalBorderItem1.Id = 96
            Me.toggleTableCellsInsideVerticalBorderItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsInsideVerticalBorderItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
            ' 
            ' toggleShowTableGridLinesItem1
            ' 
            Me.toggleShowTableGridLinesItem1.Glyph = (DirectCast(resources.GetObject("toggleShowTableGridLinesItem1.Glyph"), System.Drawing.Image))
            Me.toggleShowTableGridLinesItem1.Id = 97
            Me.toggleShowTableGridLinesItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleShowTableGridLinesItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
            ' 
            ' changeTableBorderLineStyleItem1
            ' 
            Me.changeTableBorderLineStyleItem1.Edit = Me.repositoryItemBorderLineStyle1
            borderInfo2.Color = System.Drawing.Color.Black
            borderInfo2.Frame = False
            borderInfo2.Offset = 0
            borderInfo2.Shadow = False
            borderInfo2.Style = DevExpress.XtraRichEdit.Model.BorderLineStyle.Single
            borderInfo2.Width = 10
            Me.changeTableBorderLineStyleItem1.EditValue = borderInfo2
            Me.changeTableBorderLineStyleItem1.Id = 98
            Me.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1"
            ' 
            ' repositoryItemBorderLineStyle1
            ' 
            Me.repositoryItemBorderLineStyle1.AutoHeight = False
            Me.repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemBorderLineStyle1.Control = Me.richEditControl1
            Me.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
            ' 
            ' changeTableBorderLineWeightItem1
            ' 
            Me.changeTableBorderLineWeightItem1.Edit = Me.repositoryItemBorderLineWeight1
            Me.changeTableBorderLineWeightItem1.EditValue = 20
            Me.changeTableBorderLineWeightItem1.Id = 99
            Me.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1"
            ' 
            ' repositoryItemBorderLineWeight1
            ' 
            Me.repositoryItemBorderLineWeight1.AutoHeight = False
            Me.repositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemBorderLineWeight1.Control = Me.richEditControl1
            Me.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1"
            ' 
            ' changeTableBorderColorItem1
            ' 
            Me.changeTableBorderColorItem1.Glyph = (DirectCast(resources.GetObject("changeTableBorderColorItem1.Glyph"), System.Drawing.Image))
            Me.changeTableBorderColorItem1.Id = 100
            Me.changeTableBorderColorItem1.LargeGlyph = (DirectCast(resources.GetObject("changeTableBorderColorItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
            ' 
            ' selectTableElementsItem1
            ' 
            Me.selectTableElementsItem1.Glyph = (DirectCast(resources.GetObject("selectTableElementsItem1.Glyph"), System.Drawing.Image))
            Me.selectTableElementsItem1.Id = 101
            Me.selectTableElementsItem1.LargeGlyph = (DirectCast(resources.GetObject("selectTableElementsItem1.LargeGlyph"), System.Drawing.Image))
            Me.selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableCellItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableColumnItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableRowItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableItem1) _
            })
            Me.selectTableElementsItem1.Name = "selectTableElementsItem1"
            ' 
            ' selectTableCellItem1
            ' 
            Me.selectTableCellItem1.Glyph = (DirectCast(resources.GetObject("selectTableCellItem1.Glyph"), System.Drawing.Image))
            Me.selectTableCellItem1.Id = 102
            Me.selectTableCellItem1.LargeGlyph = (DirectCast(resources.GetObject("selectTableCellItem1.LargeGlyph"), System.Drawing.Image))
            Me.selectTableCellItem1.Name = "selectTableCellItem1"
            ' 
            ' selectTableColumnItem1
            ' 
            Me.selectTableColumnItem1.Glyph = (DirectCast(resources.GetObject("selectTableColumnItem1.Glyph"), System.Drawing.Image))
            Me.selectTableColumnItem1.Id = 103
            Me.selectTableColumnItem1.LargeGlyph = (DirectCast(resources.GetObject("selectTableColumnItem1.LargeGlyph"), System.Drawing.Image))
            Me.selectTableColumnItem1.Name = "selectTableColumnItem1"
            ' 
            ' selectTableRowItem1
            ' 
            Me.selectTableRowItem1.Glyph = (DirectCast(resources.GetObject("selectTableRowItem1.Glyph"), System.Drawing.Image))
            Me.selectTableRowItem1.Id = 104
            Me.selectTableRowItem1.LargeGlyph = (DirectCast(resources.GetObject("selectTableRowItem1.LargeGlyph"), System.Drawing.Image))
            Me.selectTableRowItem1.Name = "selectTableRowItem1"
            ' 
            ' selectTableItem1
            ' 
            Me.selectTableItem1.Glyph = (DirectCast(resources.GetObject("selectTableItem1.Glyph"), System.Drawing.Image))
            Me.selectTableItem1.Id = 105
            Me.selectTableItem1.LargeGlyph = (DirectCast(resources.GetObject("selectTableItem1.LargeGlyph"), System.Drawing.Image))
            Me.selectTableItem1.Name = "selectTableItem1"
            ' 
            ' showTablePropertiesFormItem1
            ' 
            Me.showTablePropertiesFormItem1.Glyph = (DirectCast(resources.GetObject("showTablePropertiesFormItem1.Glyph"), System.Drawing.Image))
            Me.showTablePropertiesFormItem1.Id = 106
            Me.showTablePropertiesFormItem1.LargeGlyph = (DirectCast(resources.GetObject("showTablePropertiesFormItem1.LargeGlyph"), System.Drawing.Image))
            Me.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
            ' 
            ' deleteTableElementsItem1
            ' 
            Me.deleteTableElementsItem1.Glyph = (DirectCast(resources.GetObject("deleteTableElementsItem1.Glyph"), System.Drawing.Image))
            Me.deleteTableElementsItem1.Id = 107
            Me.deleteTableElementsItem1.LargeGlyph = (DirectCast(resources.GetObject("deleteTableElementsItem1.LargeGlyph"), System.Drawing.Image))
            Me.deleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showDeleteTableCellsFormItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableColumnsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableRowsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableItem1) _
            })
            Me.deleteTableElementsItem1.Name = "deleteTableElementsItem1"
            ' 
            ' showDeleteTableCellsFormItem1
            ' 
            Me.showDeleteTableCellsFormItem1.Glyph = (DirectCast(resources.GetObject("showDeleteTableCellsFormItem1.Glyph"), System.Drawing.Image))
            Me.showDeleteTableCellsFormItem1.Id = 108
            Me.showDeleteTableCellsFormItem1.LargeGlyph = (DirectCast(resources.GetObject("showDeleteTableCellsFormItem1.LargeGlyph"), System.Drawing.Image))
            Me.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1"
            ' 
            ' deleteTableColumnsItem1
            ' 
            Me.deleteTableColumnsItem1.Glyph = (DirectCast(resources.GetObject("deleteTableColumnsItem1.Glyph"), System.Drawing.Image))
            Me.deleteTableColumnsItem1.Id = 109
            Me.deleteTableColumnsItem1.LargeGlyph = (DirectCast(resources.GetObject("deleteTableColumnsItem1.LargeGlyph"), System.Drawing.Image))
            Me.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
            ' 
            ' deleteTableRowsItem1
            ' 
            Me.deleteTableRowsItem1.Glyph = (DirectCast(resources.GetObject("deleteTableRowsItem1.Glyph"), System.Drawing.Image))
            Me.deleteTableRowsItem1.Id = 110
            Me.deleteTableRowsItem1.LargeGlyph = (DirectCast(resources.GetObject("deleteTableRowsItem1.LargeGlyph"), System.Drawing.Image))
            Me.deleteTableRowsItem1.Name = "deleteTableRowsItem1"
            ' 
            ' deleteTableItem1
            ' 
            Me.deleteTableItem1.Glyph = (DirectCast(resources.GetObject("deleteTableItem1.Glyph"), System.Drawing.Image))
            Me.deleteTableItem1.Id = 111
            Me.deleteTableItem1.LargeGlyph = (DirectCast(resources.GetObject("deleteTableItem1.LargeGlyph"), System.Drawing.Image))
            Me.deleteTableItem1.Name = "deleteTableItem1"
            ' 
            ' insertTableRowAboveItem1
            ' 
            Me.insertTableRowAboveItem1.Glyph = (DirectCast(resources.GetObject("insertTableRowAboveItem1.Glyph"), System.Drawing.Image))
            Me.insertTableRowAboveItem1.Id = 112
            Me.insertTableRowAboveItem1.LargeGlyph = (DirectCast(resources.GetObject("insertTableRowAboveItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
            ' 
            ' insertTableRowBelowItem1
            ' 
            Me.insertTableRowBelowItem1.Glyph = (DirectCast(resources.GetObject("insertTableRowBelowItem1.Glyph"), System.Drawing.Image))
            Me.insertTableRowBelowItem1.Id = 113
            Me.insertTableRowBelowItem1.LargeGlyph = (DirectCast(resources.GetObject("insertTableRowBelowItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
            ' 
            ' insertTableColumnToLeftItem1
            ' 
            Me.insertTableColumnToLeftItem1.Glyph = (DirectCast(resources.GetObject("insertTableColumnToLeftItem1.Glyph"), System.Drawing.Image))
            Me.insertTableColumnToLeftItem1.Id = 114
            Me.insertTableColumnToLeftItem1.LargeGlyph = (DirectCast(resources.GetObject("insertTableColumnToLeftItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
            ' 
            ' insertTableColumnToRightItem1
            ' 
            Me.insertTableColumnToRightItem1.Glyph = (DirectCast(resources.GetObject("insertTableColumnToRightItem1.Glyph"), System.Drawing.Image))
            Me.insertTableColumnToRightItem1.Id = 115
            Me.insertTableColumnToRightItem1.LargeGlyph = (DirectCast(resources.GetObject("insertTableColumnToRightItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
            ' 
            ' showInsertTableCellsFormItem1
            ' 
            Me.showInsertTableCellsFormItem1.Glyph = (DirectCast(resources.GetObject("showInsertTableCellsFormItem1.Glyph"), System.Drawing.Image))
            Me.showInsertTableCellsFormItem1.Id = 116
            Me.showInsertTableCellsFormItem1.LargeGlyph = (DirectCast(resources.GetObject("showInsertTableCellsFormItem1.LargeGlyph"), System.Drawing.Image))
            Me.showInsertTableCellsFormItem1.Name = "showInsertTableCellsFormItem1"
            ' 
            ' mergeTableCellsItem1
            ' 
            Me.mergeTableCellsItem1.Glyph = (DirectCast(resources.GetObject("mergeTableCellsItem1.Glyph"), System.Drawing.Image))
            Me.mergeTableCellsItem1.Id = 117
            Me.mergeTableCellsItem1.LargeGlyph = (DirectCast(resources.GetObject("mergeTableCellsItem1.LargeGlyph"), System.Drawing.Image))
            Me.mergeTableCellsItem1.Name = "mergeTableCellsItem1"
            ' 
            ' showSplitTableCellsForm1
            ' 
            Me.showSplitTableCellsForm1.Glyph = (DirectCast(resources.GetObject("showSplitTableCellsForm1.Glyph"), System.Drawing.Image))
            Me.showSplitTableCellsForm1.Id = 118
            Me.showSplitTableCellsForm1.LargeGlyph = (DirectCast(resources.GetObject("showSplitTableCellsForm1.LargeGlyph"), System.Drawing.Image))
            Me.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
            ' 
            ' splitTableItem1
            ' 
            Me.splitTableItem1.Glyph = (DirectCast(resources.GetObject("splitTableItem1.Glyph"), System.Drawing.Image))
            Me.splitTableItem1.Id = 119
            Me.splitTableItem1.LargeGlyph = (DirectCast(resources.GetObject("splitTableItem1.LargeGlyph"), System.Drawing.Image))
            Me.splitTableItem1.Name = "splitTableItem1"
            ' 
            ' toggleTableCellsTopLeftAlignmentItem1
            ' 
            Me.toggleTableCellsTopLeftAlignmentItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsTopLeftAlignmentItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsTopLeftAlignmentItem1.Id = 120
            Me.toggleTableCellsTopLeftAlignmentItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsTopLeftAlignmentItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
            ' 
            ' toggleTableCellsTopCenterAlignmentItem1
            ' 
            Me.toggleTableCellsTopCenterAlignmentItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsTopCenterAlignmentItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsTopCenterAlignmentItem1.Id = 121
            Me.toggleTableCellsTopCenterAlignmentItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsTopCenterAlignmentItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
            ' 
            ' toggleTableCellsTopRightAlignmentItem1
            ' 
            Me.toggleTableCellsTopRightAlignmentItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsTopRightAlignmentItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsTopRightAlignmentItem1.Id = 122
            Me.toggleTableCellsTopRightAlignmentItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsTopRightAlignmentItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleLeftAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsMiddleLeftAlignmentItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Id = 123
            Me.toggleTableCellsMiddleLeftAlignmentItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsMiddleLeftAlignmentItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleCenterAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsMiddleCenterAlignmentItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Id = 124
            Me.toggleTableCellsMiddleCenterAlignmentItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsMiddleCenterAlignmentItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleRightAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleRightAlignmentItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsMiddleRightAlignmentItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsMiddleRightAlignmentItem1.Id = 125
            Me.toggleTableCellsMiddleRightAlignmentItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsMiddleRightAlignmentItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
            ' 
            ' toggleTableCellsBottomLeftAlignmentItem1
            ' 
            Me.toggleTableCellsBottomLeftAlignmentItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsBottomLeftAlignmentItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsBottomLeftAlignmentItem1.Id = 126
            Me.toggleTableCellsBottomLeftAlignmentItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsBottomLeftAlignmentItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
            ' 
            ' toggleTableCellsBottomCenterAlignmentItem1
            ' 
            Me.toggleTableCellsBottomCenterAlignmentItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsBottomCenterAlignmentItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsBottomCenterAlignmentItem1.Id = 127
            Me.toggleTableCellsBottomCenterAlignmentItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsBottomCenterAlignmentItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
            ' 
            ' toggleTableCellsBottomRightAlignmentItem1
            ' 
            Me.toggleTableCellsBottomRightAlignmentItem1.Glyph = (DirectCast(resources.GetObject("toggleTableCellsBottomRightAlignmentItem1.Glyph"), System.Drawing.Image))
            Me.toggleTableCellsBottomRightAlignmentItem1.Id = 128
            Me.toggleTableCellsBottomRightAlignmentItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleTableCellsBottomRightAlignmentItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
            ' 
            ' insertTableOfContentsItem1
            ' 
            Me.insertTableOfContentsItem1.Glyph = (DirectCast(resources.GetObject("insertTableOfContentsItem1.Glyph"), System.Drawing.Image))
            Me.insertTableOfContentsItem1.Id = 129
            Me.insertTableOfContentsItem1.LargeGlyph = (DirectCast(resources.GetObject("insertTableOfContentsItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertTableOfContentsItem1.Name = "insertTableOfContentsItem1"
            ' 
            ' updateTableOfContentsItem1
            ' 
            Me.updateTableOfContentsItem1.Glyph = (DirectCast(resources.GetObject("updateTableOfContentsItem1.Glyph"), System.Drawing.Image))
            Me.updateTableOfContentsItem1.Id = 130
            Me.updateTableOfContentsItem1.LargeGlyph = (DirectCast(resources.GetObject("updateTableOfContentsItem1.LargeGlyph"), System.Drawing.Image))
            Me.updateTableOfContentsItem1.Name = "updateTableOfContentsItem1"
            ' 
            ' addParagraphsToTableOfContentItem1
            ' 
            Me.addParagraphsToTableOfContentItem1.Glyph = (DirectCast(resources.GetObject("addParagraphsToTableOfContentItem1.Glyph"), System.Drawing.Image))
            Me.addParagraphsToTableOfContentItem1.Id = 131
            Me.addParagraphsToTableOfContentItem1.LargeGlyph = (DirectCast(resources.GetObject("addParagraphsToTableOfContentItem1.LargeGlyph"), System.Drawing.Image))
            Me.addParagraphsToTableOfContentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem3), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem4), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem5), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem6), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem7), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem8), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem9), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem10) _
            })
            Me.addParagraphsToTableOfContentItem1.Name = "addParagraphsToTableOfContentItem1"
            ' 
            ' setParagraphHeadingLevelItem1
            ' 
            Me.setParagraphHeadingLevelItem1.Id = 132
            Me.setParagraphHeadingLevelItem1.Name = "setParagraphHeadingLevelItem1"
            Me.setParagraphHeadingLevelItem1.OutlineLevel = 0
            ' 
            ' setParagraphHeadingLevelItem2
            ' 
            Me.setParagraphHeadingLevelItem2.Id = 133
            Me.setParagraphHeadingLevelItem2.Name = "setParagraphHeadingLevelItem2"
            Me.setParagraphHeadingLevelItem2.OutlineLevel = 1
            ' 
            ' setParagraphHeadingLevelItem3
            ' 
            Me.setParagraphHeadingLevelItem3.Id = 134
            Me.setParagraphHeadingLevelItem3.Name = "setParagraphHeadingLevelItem3"
            Me.setParagraphHeadingLevelItem3.OutlineLevel = 2
            ' 
            ' setParagraphHeadingLevelItem4
            ' 
            Me.setParagraphHeadingLevelItem4.Id = 135
            Me.setParagraphHeadingLevelItem4.Name = "setParagraphHeadingLevelItem4"
            Me.setParagraphHeadingLevelItem4.OutlineLevel = 3
            ' 
            ' setParagraphHeadingLevelItem5
            ' 
            Me.setParagraphHeadingLevelItem5.Id = 136
            Me.setParagraphHeadingLevelItem5.Name = "setParagraphHeadingLevelItem5"
            Me.setParagraphHeadingLevelItem5.OutlineLevel = 4
            ' 
            ' setParagraphHeadingLevelItem6
            ' 
            Me.setParagraphHeadingLevelItem6.Id = 137
            Me.setParagraphHeadingLevelItem6.Name = "setParagraphHeadingLevelItem6"
            Me.setParagraphHeadingLevelItem6.OutlineLevel = 5
            ' 
            ' setParagraphHeadingLevelItem7
            ' 
            Me.setParagraphHeadingLevelItem7.Id = 138
            Me.setParagraphHeadingLevelItem7.Name = "setParagraphHeadingLevelItem7"
            Me.setParagraphHeadingLevelItem7.OutlineLevel = 6
            ' 
            ' setParagraphHeadingLevelItem8
            ' 
            Me.setParagraphHeadingLevelItem8.Id = 139
            Me.setParagraphHeadingLevelItem8.Name = "setParagraphHeadingLevelItem8"
            Me.setParagraphHeadingLevelItem8.OutlineLevel = 7
            ' 
            ' setParagraphHeadingLevelItem9
            ' 
            Me.setParagraphHeadingLevelItem9.Id = 140
            Me.setParagraphHeadingLevelItem9.Name = "setParagraphHeadingLevelItem9"
            Me.setParagraphHeadingLevelItem9.OutlineLevel = 8
            ' 
            ' setParagraphHeadingLevelItem10
            ' 
            Me.setParagraphHeadingLevelItem10.Id = 141
            Me.setParagraphHeadingLevelItem10.Name = "setParagraphHeadingLevelItem10"
            Me.setParagraphHeadingLevelItem10.OutlineLevel = 9
            ' 
            ' switchToSimpleViewItem1
            ' 
            Me.switchToSimpleViewItem1.Glyph = (DirectCast(resources.GetObject("switchToSimpleViewItem1.Glyph"), System.Drawing.Image))
            Me.switchToSimpleViewItem1.Id = 143
            Me.switchToSimpleViewItem1.LargeGlyph = (DirectCast(resources.GetObject("switchToSimpleViewItem1.LargeGlyph"), System.Drawing.Image))
            Me.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
            ' 
            ' switchToDraftViewItem1
            ' 
            Me.switchToDraftViewItem1.Glyph = (DirectCast(resources.GetObject("switchToDraftViewItem1.Glyph"), System.Drawing.Image))
            Me.switchToDraftViewItem1.Id = 144
            Me.switchToDraftViewItem1.LargeGlyph = (DirectCast(resources.GetObject("switchToDraftViewItem1.LargeGlyph"), System.Drawing.Image))
            Me.switchToDraftViewItem1.Name = "switchToDraftViewItem1"
            ' 
            ' switchToPrintLayoutViewItem1
            ' 
            Me.switchToPrintLayoutViewItem1.Glyph = (DirectCast(resources.GetObject("switchToPrintLayoutViewItem1.Glyph"), System.Drawing.Image))
            Me.switchToPrintLayoutViewItem1.Id = 145
            Me.switchToPrintLayoutViewItem1.LargeGlyph = (DirectCast(resources.GetObject("switchToPrintLayoutViewItem1.LargeGlyph"), System.Drawing.Image))
            Me.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
            ' 
            ' toggleShowHorizontalRulerItem1
            ' 
            Me.toggleShowHorizontalRulerItem1.Glyph = (DirectCast(resources.GetObject("toggleShowHorizontalRulerItem1.Glyph"), System.Drawing.Image))
            Me.toggleShowHorizontalRulerItem1.Id = 146
            Me.toggleShowHorizontalRulerItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleShowHorizontalRulerItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1"
            ' 
            ' toggleShowVerticalRulerItem1
            ' 
            Me.toggleShowVerticalRulerItem1.Glyph = (DirectCast(resources.GetObject("toggleShowVerticalRulerItem1.Glyph"), System.Drawing.Image))
            Me.toggleShowVerticalRulerItem1.Id = 147
            Me.toggleShowVerticalRulerItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleShowVerticalRulerItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1"
            ' 
            ' zoomOutItem1
            ' 
            Me.zoomOutItem1.Glyph = (DirectCast(resources.GetObject("zoomOutItem1.Glyph"), System.Drawing.Image))
            Me.zoomOutItem1.Id = 148
            Me.zoomOutItem1.LargeGlyph = (DirectCast(resources.GetObject("zoomOutItem1.LargeGlyph"), System.Drawing.Image))
            Me.zoomOutItem1.Name = "zoomOutItem1"
            ' 
            ' zoomInItem1
            ' 
            Me.zoomInItem1.Glyph = (DirectCast(resources.GetObject("zoomInItem1.Glyph"), System.Drawing.Image))
            Me.zoomInItem1.Id = 149
            Me.zoomInItem1.LargeGlyph = (DirectCast(resources.GetObject("zoomInItem1.LargeGlyph"), System.Drawing.Image))
            Me.zoomInItem1.Name = "zoomInItem1"
            ' 
            ' fileNewItem1
            ' 
            Me.fileNewItem1.Glyph = (DirectCast(resources.GetObject("fileNewItem1.Glyph"), System.Drawing.Image))
            Me.fileNewItem1.Id = 150
            Me.fileNewItem1.LargeGlyph = (DirectCast(resources.GetObject("fileNewItem1.LargeGlyph"), System.Drawing.Image))
            Me.fileNewItem1.Name = "fileNewItem1"
            ' 
            ' fileOpenItem1
            ' 
            Me.fileOpenItem1.Glyph = (DirectCast(resources.GetObject("fileOpenItem1.Glyph"), System.Drawing.Image))
            Me.fileOpenItem1.Id = 151
            Me.fileOpenItem1.LargeGlyph = (DirectCast(resources.GetObject("fileOpenItem1.LargeGlyph"), System.Drawing.Image))
            Me.fileOpenItem1.Name = "fileOpenItem1"
            ' 
            ' fileSaveItem1
            ' 
            Me.fileSaveItem1.Glyph = (DirectCast(resources.GetObject("fileSaveItem1.Glyph"), System.Drawing.Image))
            Me.fileSaveItem1.Id = 152
            Me.fileSaveItem1.LargeGlyph = (DirectCast(resources.GetObject("fileSaveItem1.LargeGlyph"), System.Drawing.Image))
            Me.fileSaveItem1.Name = "fileSaveItem1"
            ' 
            ' fileSaveAsItem1
            ' 
            Me.fileSaveAsItem1.Glyph = (DirectCast(resources.GetObject("fileSaveAsItem1.Glyph"), System.Drawing.Image))
            Me.fileSaveAsItem1.Id = 153
            Me.fileSaveAsItem1.LargeGlyph = (DirectCast(resources.GetObject("fileSaveAsItem1.LargeGlyph"), System.Drawing.Image))
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            ' 
            ' quickPrintItem1
            ' 
            Me.quickPrintItem1.Glyph = (DirectCast(resources.GetObject("quickPrintItem1.Glyph"), System.Drawing.Image))
            Me.quickPrintItem1.Id = 154
            Me.quickPrintItem1.LargeGlyph = (DirectCast(resources.GetObject("quickPrintItem1.LargeGlyph"), System.Drawing.Image))
            Me.quickPrintItem1.Name = "quickPrintItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Glyph = (DirectCast(resources.GetObject("printItem1.Glyph"), System.Drawing.Image))
            Me.printItem1.Id = 155
            Me.printItem1.LargeGlyph = (DirectCast(resources.GetObject("printItem1.LargeGlyph"), System.Drawing.Image))
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Glyph = (DirectCast(resources.GetObject("printPreviewItem1.Glyph"), System.Drawing.Image))
            Me.printPreviewItem1.Id = 156
            Me.printPreviewItem1.LargeGlyph = (DirectCast(resources.GetObject("printPreviewItem1.LargeGlyph"), System.Drawing.Image))
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' undoItem1
            ' 
            Me.undoItem1.Glyph = (DirectCast(resources.GetObject("undoItem1.Glyph"), System.Drawing.Image))
            Me.undoItem1.Id = 157
            Me.undoItem1.LargeGlyph = (DirectCast(resources.GetObject("undoItem1.LargeGlyph"), System.Drawing.Image))
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            Me.redoItem1.Glyph = (DirectCast(resources.GetObject("redoItem1.Glyph"), System.Drawing.Image))
            Me.redoItem1.Id = 158
            Me.redoItem1.LargeGlyph = (DirectCast(resources.GetObject("redoItem1.LargeGlyph"), System.Drawing.Image))
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' insertMergeFieldItem1
            ' 
            Me.insertMergeFieldItem1.Glyph = (DirectCast(resources.GetObject("insertMergeFieldItem1.Glyph"), System.Drawing.Image))
            Me.insertMergeFieldItem1.Id = 159
            Me.insertMergeFieldItem1.LargeGlyph = (DirectCast(resources.GetObject("insertMergeFieldItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
            ' 
            ' showAllFieldCodesItem1
            ' 
            Me.showAllFieldCodesItem1.Glyph = (DirectCast(resources.GetObject("showAllFieldCodesItem1.Glyph"), System.Drawing.Image))
            Me.showAllFieldCodesItem1.Id = 160
            Me.showAllFieldCodesItem1.LargeGlyph = (DirectCast(resources.GetObject("showAllFieldCodesItem1.LargeGlyph"), System.Drawing.Image))
            Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            ' 
            ' showAllFieldResultsItem1
            ' 
            Me.showAllFieldResultsItem1.Glyph = (DirectCast(resources.GetObject("showAllFieldResultsItem1.Glyph"), System.Drawing.Image))
            Me.showAllFieldResultsItem1.Id = 161
            Me.showAllFieldResultsItem1.LargeGlyph = (DirectCast(resources.GetObject("showAllFieldResultsItem1.LargeGlyph"), System.Drawing.Image))
            Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            ' 
            ' toggleViewMergedDataItem1
            ' 
            Me.toggleViewMergedDataItem1.Glyph = (DirectCast(resources.GetObject("toggleViewMergedDataItem1.Glyph"), System.Drawing.Image))
            Me.toggleViewMergedDataItem1.Id = 162
            Me.toggleViewMergedDataItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleViewMergedDataItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
            ' 
            ' tableToolsRibbonPageCategory1
            ' 
            Me.tableToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb((CInt((CByte(252)))), (CInt((CByte(233)))), (CInt((CByte(20)))))
            Me.tableToolsRibbonPageCategory1.Control = Me.richEditControl1
            Me.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1"
            Me.tableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.tableDesignRibbonPage1, Me.tableLayoutRibbonPage1})
            ' 
            ' tableDesignRibbonPage1
            ' 
            Me.tableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableStylesRibbonPageGroup1, Me.tableDrawBordersRibbonPageGroup1})
            Me.tableDesignRibbonPage1.Name = "tableDesignRibbonPage1"
            ' 
            ' tableStylesRibbonPageGroup1
            ' 
            Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.changeTableCellsShadingItem1)
            Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.changeTableBordersItem1)
            Me.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1"
            ' 
            ' tableDrawBordersRibbonPageGroup1
            ' 
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineStyleItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineWeightItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderColorItem1)
            Me.tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1"
            ' 
            ' tableLayoutRibbonPage1
            ' 
            Me.tableLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableTableRibbonPageGroup1, Me.tableRowsAndColumnsRibbonPageGroup1, Me.tableMergeRibbonPageGroup1, Me.tableAlignmentRibbonPageGroup1})
            Me.tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1"
            ' 
            ' tableTableRibbonPageGroup1
            ' 
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.selectTableElementsItem1)
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.toggleShowTableGridLinesItem1)
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.showTablePropertiesFormItem1)
            Me.tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1"
            ' 
            ' tableRowsAndColumnsRibbonPageGroup1
            ' 
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.deleteTableElementsItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowAboveItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowBelowItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToLeftItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToRightItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.showInsertTableCellsFormItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1"
            ' 
            ' tableMergeRibbonPageGroup1
            ' 
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.mergeTableCellsItem1)
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.showSplitTableCellsForm1)
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.splitTableItem1)
            Me.tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1"
            ' 
            ' tableAlignmentRibbonPageGroup1
            ' 
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1"
            ' 
            ' homeRibbonPage1
            ' 
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.paragraphRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.editingRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            ' 
            ' clipboardRibbonPageGroup1
            ' 
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteSpecialItem1)
            Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
            ' 
            ' fontRibbonPageGroup1
            ' 
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeFontNameItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeFontColorItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeFontBackColorItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontBoldItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontItalicItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontUnderlineItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontStrikeoutItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontSuperscriptItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontSubscriptItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeTextCaseItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.showFontFormItem1)
            Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
            ' 
            ' paragraphRibbonPageGroup1
            ' 
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.changeParagraphLineSpacingItem1)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleBulletedListItem1)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleNumberingListItem1)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleMultiLevelListItem1)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.decreaseIndentItem1)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.increaseIndentItem1)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.showParagraphFormItem1)
            Me.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
            ' 
            ' stylesRibbonPageGroup1
            ' 
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.changeStyleItem1)
            Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
            ' 
            ' editingRibbonPageGroup1
            ' 
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1)
            Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            ' 
            ' insertRibbonPage1
            ' 
            Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pagesRibbonPageGroup1, Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.headerFooterRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
            Me.insertRibbonPage1.Name = "insertRibbonPage1"
            ' 
            ' pagesRibbonPageGroup1
            ' 
            Me.pagesRibbonPageGroup1.ItemLinks.Add(Me.insertPageBreakItem1)
            Me.pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
            ' 
            ' tablesRibbonPageGroup1
            ' 
            Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.insertTableItem1)
            Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
            ' 
            ' illustrationsRibbonPageGroup1
            ' 
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1)
            Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
            ' 
            ' linksRibbonPageGroup1
            ' 
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertBookmarkItem1)
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertHyperlinkItem1)
            Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
            ' 
            ' headerFooterRibbonPageGroup1
            ' 
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageHeaderItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageFooterItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageNumberItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageCountItem1)
            Me.headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1"
            ' 
            ' symbolsRibbonPageGroup1
            ' 
            Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.insertSymbolItem1)
            Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
            ' 
            ' pageLayoutRibbonPage1
            ' 
            Me.pageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pageSetupRibbonPageGroup1})
            Me.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1"
            ' 
            ' pageSetupRibbonPageGroup1
            ' 
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageMarginsItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageOrientationItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPaperKindItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionColumnsItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.insertBreakItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionLineNumberingItem1)
            Me.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1"
            ' 
            ' referencesRibbonPage1
            ' 
            Me.referencesRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableOfContentsRibbonPageGroup1})
            Me.referencesRibbonPage1.Name = "referencesRibbonPage1"
            ' 
            ' tableOfContentsRibbonPageGroup1
            ' 
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.insertTableOfContentsItem1)
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.updateTableOfContentsItem1)
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.addParagraphsToTableOfContentItem1)
            Me.tableOfContentsRibbonPageGroup1.Name = "tableOfContentsRibbonPageGroup1"
            ' 
            ' viewRibbonPage1
            ' 
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.documentViewsRibbonPageGroup1, Me.showRibbonPageGroup1, Me.zoomRibbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            ' 
            ' documentViewsRibbonPageGroup1
            ' 
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToSimpleViewItem1)
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToDraftViewItem1)
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToPrintLayoutViewItem1)
            Me.documentViewsRibbonPageGroup1.Name = "documentViewsRibbonPageGroup1"
            ' 
            ' showRibbonPageGroup1
            ' 
            Me.showRibbonPageGroup1.ItemLinks.Add(Me.toggleShowHorizontalRulerItem1)
            Me.showRibbonPageGroup1.ItemLinks.Add(Me.toggleShowVerticalRulerItem1)
            Me.showRibbonPageGroup1.Name = "showRibbonPageGroup1"
            ' 
            ' zoomRibbonPageGroup1
            ' 
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomOutItem1)
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomInItem1)
            Me.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1"
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' mailingsRibbonPage1
            ' 
            Me.mailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.mailMergeRibbonPageGroup1})
            Me.mailingsRibbonPage1.Name = "mailingsRibbonPage1"
            ' 
            ' mailMergeRibbonPageGroup1
            ' 
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.insertMergeFieldItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.toggleViewMergedDataItem1)
            Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.btn_InsertTable)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(860, 39)
            Me.panelControl1.TabIndex = 1
            ' 
            ' btn_InsertTable
            ' 
            Me.btn_InsertTable.Location = New System.Drawing.Point(12, 10)
            Me.btn_InsertTable.Name = "btn_InsertTable"
            Me.btn_InsertTable.Size = New System.Drawing.Size(141, 23)
            Me.btn_InsertTable.TabIndex = 0
            Me.btn_InsertTable.Text = "Insert Multiplication Table"
            Me.btn_InsertTable.UseVisualStyleBackColor = True
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.cutItem1)
            Me.richEditBarController1.BarItems.Add(Me.copyItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteSpecialItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontNameItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontSizeItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontBoldItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontItalicItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.makeTextUpperCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.makeTextLowerCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.clearFormattingItem1)
            Me.richEditBarController1.BarItems.Add(Me.showFontFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeParagraphLineSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.showLineSpacingFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
            Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.findItem1)
            Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBookmarkItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertHyperlinkItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageHeaderItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageNumberItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageCountItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSymbolItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setNormalSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setNarrowSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setModerateSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setWideSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeSectionPageOrientationItem1)
            Me.richEditBarController1.BarItems.Add(Me.setPortraitPageOrientationItem1)
            Me.richEditBarController1.BarItems.Add(Me.setLandscapePageOrientationItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeSectionPaperKindItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeSectionColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionOneColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionTwoColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionThreeColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.showColumnsSetupFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem2)
            Me.richEditBarController1.BarItems.Add(Me.insertColumnBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSectionBreakNextPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSectionBreakEvenPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSectionBreakOddPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeSectionLineNumberingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingNoneItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingContinuousItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewSectionItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphSuppressLineNumbersItem1)
            Me.richEditBarController1.BarItems.Add(Me.showLineNumberingFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableCellsShadingItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsLeftBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsRightBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.resetTableCellsAllBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsAllBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsOutsideBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideHorizontalBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideVerticalBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowTableGridLinesItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderLineStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderLineWeightItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableElementsItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableCellItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableRowItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.showTablePropertiesFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableElementsItem1)
            Me.richEditBarController1.BarItems.Add(Me.showDeleteTableCellsFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableRowsItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableRowAboveItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableRowBelowItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableColumnToLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableColumnToRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.showInsertTableCellsFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.mergeTableCellsItem1)
            Me.richEditBarController1.BarItems.Add(Me.showSplitTableCellsForm1)
            Me.richEditBarController1.BarItems.Add(Me.splitTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableOfContentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.updateTableOfContentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.addParagraphsToTableOfContentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem1)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem2)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem3)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem4)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem5)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem6)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem7)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem8)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem9)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem10)
            Me.richEditBarController1.BarItems.Add(Me.switchToSimpleViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToDraftViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToPrintLayoutViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowHorizontalRulerItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowVerticalRulerItem1)
            Me.richEditBarController1.BarItems.Add(Me.zoomOutItem1)
            Me.richEditBarController1.BarItems.Add(Me.zoomInItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.printItem1)
            Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertMergeFieldItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleViewMergedDataItem1)
            Me.richEditBarController1.Control = Me.richEditControl1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(860, 500)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            DirectCast(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents btn_InsertTable As System.Windows.Forms.Button
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Private pasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
        Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
        Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
        Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
        Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
        Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
        Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
        Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
        Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
        Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
        Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
        Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
        Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
        Private changeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem
        Private makeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem
        Private makeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem
        Private toggleTextCaseItem1 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem
        Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
        Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
        Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
        Private showFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem
        Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
        Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
        Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
        Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
        Private changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
        Private setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
        Private setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
        Private setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
        Private showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
        Private addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
        Private removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
        Private addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
        Private removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
        Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
        Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
        Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
        Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
        Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
        Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
        Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
        Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
        Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
        Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
        Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
        Private insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
        Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
        Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
        Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
        Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
        Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
        Private insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
        Private insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
        Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
        Private changeSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem
        Private setNormalSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem
        Private setNarrowSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem
        Private setModerateSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem
        Private setWideSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem
        Private changeSectionPageOrientationItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem
        Private setPortraitPageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem
        Private setLandscapePageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem
        Private changeSectionPaperKindItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem
        Private changeSectionColumnsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem
        Private setSectionOneColumnItem1 As DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem
        Private setSectionTwoColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem
        Private setSectionThreeColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem
        Private showColumnsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem
        Private insertBreakItem1 As DevExpress.XtraRichEdit.UI.InsertBreakItem
        Private insertPageBreakItem2 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
        Private insertColumnBreakItem1 As DevExpress.XtraRichEdit.UI.InsertColumnBreakItem
        Private insertSectionBreakNextPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem
        Private insertSectionBreakEvenPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem
        Private insertSectionBreakOddPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem
        Private changeSectionLineNumberingItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem
        Private setSectionLineNumberingNoneItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem
        Private setSectionLineNumberingContinuousItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem
        Private setSectionLineNumberingRestartNewPageItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem
        Private setSectionLineNumberingRestartNewSectionItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem
        Private toggleParagraphSuppressLineNumbersItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem
        Private showLineNumberingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem
        Private changeTableCellsShadingItem1 As DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem
        Private changeTableBordersItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBordersItem
        Private toggleTableCellsBottomBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem
        Private toggleTableCellsTopBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem
        Private toggleTableCellsLeftBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem
        Private toggleTableCellsRightBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem
        Private resetTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem
        Private toggleTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem
        Private toggleTableCellsOutsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem
        Private toggleTableCellsInsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem
        Private toggleTableCellsInsideHorizontalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem
        Private toggleTableCellsInsideVerticalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem
        Private toggleShowTableGridLinesItem1 As DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem
        Private changeTableBorderLineStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem
        Private repositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
        Private changeTableBorderLineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem
        Private repositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
        Private changeTableBorderColorItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem
        Private selectTableElementsItem1 As DevExpress.XtraRichEdit.UI.SelectTableElementsItem
        Private selectTableCellItem1 As DevExpress.XtraRichEdit.UI.SelectTableCellItem
        Private selectTableColumnItem1 As DevExpress.XtraRichEdit.UI.SelectTableColumnItem
        Private selectTableRowItem1 As DevExpress.XtraRichEdit.UI.SelectTableRowItem
        Private selectTableItem1 As DevExpress.XtraRichEdit.UI.SelectTableItem
        Private showTablePropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem
        Private deleteTableElementsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableElementsItem
        Private showDeleteTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem
        Private deleteTableColumnsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem
        Private deleteTableRowsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableRowsItem
        Private deleteTableItem1 As DevExpress.XtraRichEdit.UI.DeleteTableItem
        Private insertTableRowAboveItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem
        Private insertTableRowBelowItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem
        Private insertTableColumnToLeftItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem
        Private insertTableColumnToRightItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem
        Private showInsertTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem
        Private mergeTableCellsItem1 As DevExpress.XtraRichEdit.UI.MergeTableCellsItem
        Private showSplitTableCellsForm1 As DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm
        Private splitTableItem1 As DevExpress.XtraRichEdit.UI.SplitTableItem
        Private toggleTableCellsTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
        Private toggleTableCellsTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
        Private toggleTableCellsTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
        Private toggleTableCellsMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
        Private toggleTableCellsMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
        Private toggleTableCellsMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
        Private toggleTableCellsBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
        Private toggleTableCellsBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
        Private toggleTableCellsBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
        Private insertTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem
        Private updateTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem
        Private addParagraphsToTableOfContentItem1 As DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem
        Private setParagraphHeadingLevelItem1 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem2 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem3 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem4 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem5 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem6 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem7 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem8 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem9 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem10 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private tableToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory
        Private tableDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.TableDesignRibbonPage
        Private tableStylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup
        Private tableDrawBordersRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup
        Private tableLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage
        Private tableTableRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup
        Private tableRowsAndColumnsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup
        Private tableMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup
        Private tableAlignmentRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup
        Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
        Private clipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
        Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
        Private paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
        Private stylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
        Private editingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
        Private insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
        Private pagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
        Private tablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
        Private illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
        Private linksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
        Private headerFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
        Private symbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
        Private pageLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage
        Private pageSetupRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup
        Private referencesRibbonPage1 As DevExpress.XtraRichEdit.UI.ReferencesRibbonPage
        Private tableOfContentsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Private switchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
        Private switchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
        Private switchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
        Private toggleShowHorizontalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem
        Private toggleShowVerticalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem
        Private zoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem
        Private zoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem
        Private viewRibbonPage1 As DevExpress.XtraRichEdit.UI.ViewRibbonPage
        Private documentViewsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup
        Private showRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup
        Private zoomRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup
        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Private fileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
        Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
        Private insertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
        Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
        Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
        Private toggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
        Private mailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage
        Private mailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
    End Class
End Namespace