// Last Modified date : 31-05-2012 - 12:00


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Data.SqlServerCe;
using MyUtilities;
using System.Windows.Forms;
using System.Text.RegularExpressions;







namespace MyUtilities
{



    /*********************************************************************************
     * 
     *                                  Classes and structures
     *                             
     * *******************************************************************************/
    public struct DGVColumnAppearance
    {
        public bool Visible;
        public int Width;
        public int DisplayIndex;
        public DGVColumnAppearance(bool V, int W, int D_Index)
        {
            Visible = V;
            Width = W;
            DisplayIndex = D_Index;
        }
        public static void SetDGVColumnProperties(DataGridViewColumn ParamCol, bool ColVisibility, int ColIndex, int ColWidth, string ColHeader, DataGridViewContentAlignment ColAlignment)
        {
            ParamCol.Visible = ColVisibility;
            ParamCol.DisplayIndex = ColIndex;
            ParamCol.Width = ColWidth;
            ParamCol.HeaderText = ColHeader;
            ParamCol.HeaderCell.Style.Alignment = ColAlignment;
        }

    }



    public static class AppearanceHandler
    {
        public static void SetErrorAppearance(Control Ctrl)
        {
            Ctrl.BackColor = System.Drawing.Color.LightSalmon;
        }

        public static void SetErrorAppearance(Label ParamLb, TextBox ParamTxt, ToolTip ParamToolTip, string ErrorMsg)
        {
            ParamLb.ForeColor = System.Drawing.Color.Firebrick;
            ParamTxt.BackColor = System.Drawing.Color.LightSalmon;
            ParamToolTip.SetToolTip(ParamTxt, ErrorMsg);
        }

        public static void SetErrorAppearance(List<ErrorCtrlMsg> ErrorCtrls, ToolTip ParamToolTip)
        {
            foreach (ErrorCtrlMsg CtrlMsg in ErrorCtrls)
            {
                CtrlMsg.Ctrl.BackColor = System.Drawing.Color.Red;
                ParamToolTip.SetToolTip(CtrlMsg.Ctrl, CtrlMsg.ErrorMsg);
            }
            ParamToolTip.Active = true;
        }

        public static void ResetInitialAppearance(List<ErrorCtrlMsg> ErrorCtrls, ToolTip ParamToolTip)
        {
            foreach (ErrorCtrlMsg CtrlMsg in ErrorCtrls)
            {
                CtrlMsg.Ctrl.BackColor = System.Drawing.Color.White;
            }
            ParamToolTip.Active = false;
        }

        public static void ResetInitialAppearance(Label ParamLb, TextBox ParamTxt)
        {
            ParamLb.ForeColor = System.Drawing.Color.Black;
            ParamTxt.BackColor = System.Drawing.Color.White;
        }

        public static void SetReadOnlyAppearance(TextBox[] ParamControls, bool Mode)
        {
            System.Drawing.Color BackColor;
            System.Drawing.Color ForeColor;

            if (Mode) // Appearance for the ReadOnly Mode
            {
                BackColor = System.Drawing.Color.White;
                ForeColor = System.Drawing.Color.Black;
            }
            else // Appearance for the Editable Mode
            {
                BackColor = System.Drawing.Color.White;
                ForeColor = System.Drawing.Color.Black;
            }

            foreach (TextBox TxtB in ParamControls)
            {
                TxtB.ReadOnly = Mode;
                TxtB.BackColor = BackColor;
                TxtB.ForeColor = ForeColor;
            }
        }

        public static void SetReadOnlyAppearance(TextBox ParamControl, bool Mode)
        {
            System.Drawing.Color BackColor;
            System.Drawing.Color ForeColor;

            if (Mode) // Appearance for the ReadOnly Mode
            {
                BackColor = System.Drawing.Color.White;
                ForeColor = System.Drawing.Color.Black;
            }
            else // Appearance for the Editable Mode
            {
                BackColor = System.Drawing.Color.White;
                ForeColor = System.Drawing.Color.Black;
            }

            ParamControl.ReadOnly = Mode;
        }

        public static void HideControls(Control[] ParamControls)
        {
            foreach (Control Ctrl in ParamControls)
            {
                Ctrl.Visible = false;
            }

        }

        public static void ShowControls(Control[] ParamControls)
        {
            foreach (Control Ctrl in ParamControls)
            {
                Ctrl.Visible = true;
            }
        }

        public static void SetEmptyAppearance(List<EmptyCtrlMsg> EmptyCtrls, ToolTip ParamToolTip)
        {
            foreach (EmptyCtrlMsg CtrlMsg in EmptyCtrls)
            {
                CtrlMsg.Ctrl.BackColor = System.Drawing.Color.LightGray;
                ParamToolTip.SetToolTip(CtrlMsg.Ctrl, CtrlMsg.Msg);
            }
            ParamToolTip.Active = true;
        }

        public static void ResetInitialAppearance(List<EmptyCtrlMsg> EmptyCtrls, ToolTip ParamToolTip)
        {
            foreach (EmptyCtrlMsg CtrlMsg in EmptyCtrls)
            {
                CtrlMsg.Ctrl.BackColor = System.Drawing.Color.White;
            }
            ParamToolTip.Active = false;
        }
    }

    public struct ErrorCtrlMsg
    {
        public Control Ctrl;
        public string ErrorMsg;
        public ErrorCtrlMsg(Control ParamCtrl, string ParamErrorMsg)
        {
            Ctrl = ParamCtrl;
            ErrorMsg = ParamErrorMsg;
        }
    }

    public struct EmptyCtrlMsg
    {
        public Control Ctrl;
        public string Msg;
        public EmptyCtrlMsg(Control ParamCtrl, string ParamMsg)
        {
            Ctrl = ParamCtrl;
            Msg = ParamMsg;
        }
    }

    public static class ComboUtilities
    {

        public static void BindCmbToDataSource(SqlCeConnection MyConnection, ComboBox Cmb, string ParamTableName, string ParamValueMember, string ParamDisplayMember)
        {
            DataTable dtSource;
            dtSource = DataBaseAccessUtilities.SelectRequest("SELECT * FROM " + ParamTableName, MyConnection);
            if (dtSource != null)
            {
                Cmb.DataSource = dtSource;
                Cmb.ValueMember = ParamValueMember;
                Cmb.DisplayMember = ParamDisplayMember;
                Cmb.SelectedIndex = -1;
            }
        }
        //public static void BindCmbToDataSource(SqlCeConnection MyConnection, ComboBox Cmb, string ParamTableName, String FieldName, string FieldValue, string ParamValueMember, string ParamDisplayMember)
        //{
        //    DataTable dtSource;
        //    if (DataBaseAccessLayer.SelectDataTable(MyConnection, ParamTableName, FieldName, FieldValue, out dtSource))
        //    {
        //        Cmb.DataSource = dtSource;
        //        Cmb.ValueMember = ParamValueMember;
        //        Cmb.DisplayMember = ParamDisplayMember;
        //        Cmb.SelectedIndex = -1;
        //    }
        //}
    }
    
    public static class GridUtilities
    {
        public static int GetRowIndexFromDGVByValue(DataGridView DGV, string SearchColumnName, string SearchedValue)
        {
            for (int i = 0; i < DGV.RowCount; i++)
            {
                if (DGV.Rows[i].Cells[SearchColumnName].Value.ToString() == SearchedValue)
                {
                    return i;
                }
            }
            
            return -1;
        }
        public static int GetDataRowIndexFromDataTableByValue(DataTable ParamDt, string FieldName, string SearchedValue)
        {
            if (ParamDt != null)
            {
                for (int i = 0; i < ParamDt.Rows.Count; i++)
                {
                    if (ParamDt.Rows[i][FieldName].ToString() == SearchedValue)
                        return i;
                }
            }
            return -1;
        }

        public static void SelectRowFromDGVByValue(DataGridView DGV, string SearchColumnName, string SearchedValue)
        {
            int SearchedRowIndex;
            SearchedRowIndex = GetRowIndexFromDGVByValue(DGV, SearchColumnName, SearchedValue);
            //MessageBox.Show("index : " + SearchedRowIndex);
            if (SearchedRowIndex != -1)
            {
                DGV.Rows[SearchedRowIndex].Selected = true;
                DGV.FirstDisplayedScrollingRowIndex = SearchedRowIndex;
            }
            else
                MessageBox.Show("La ligne n'existe pas", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void SelectRowFromDGVByIndex(DataGridView DGV, int RowIndex)
        {
            if (DGV != null && DGV.RowCount > 0)
            {
                if ((RowIndex >= 0 && RowIndex < DGV.RowCount))
                {
                    DGV.Rows[RowIndex].Selected = true;
                    DGV.FirstDisplayedScrollingRowIndex = RowIndex;
                }
                else
                    MessageBox.Show("L'index de la ligne n'est pas valide", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void BindDataToDGV(DataGridView dgv, DataTable dt)
        {            
            if (dt != null)
            {
                dgv.DataSource = dt;
            }                         
        }
        public static void BindDataToDGV(DataGridView dgv, List<object> L)
        {
            if (L != null)
            {
                dgv.DataSource = L;
            }
        }

        public static DataRow GetSelectedDataRowFromDGV(DataGridView dgv, DataTable dtSource, string GrdColId, string SourceColId)
        {
            if (dtSource != null && dgv.SelectedRows != null)
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    // Recherche de la ligne sélectionnée dans la grille ainsi que la valeur de l'identifiant
                    string CurrentRowId = dgv.SelectedRows[0].Cells[GrdColId].Value.ToString();
                    // Recherche de la ligne qui lui correspond dans la DataTable
                    DataRow[] SelectionResult = null;

                    // Il faut penser à traiter le cas des caractères spéciaux dans la chaine représentant
                    // la requête passée au Select
                    CurrentRowId = CurrentRowId.Replace("'", "\'");  
                    SelectionResult = dtSource.Select(SourceColId + " = " + CurrentRowId + "");

                    // Renvoi du premier élément du tableau de DataRow qui est renvoyé par la méthode Select
                    if (SelectionResult != null && SelectionResult.Length != 0)
                        return SelectionResult[0];
                    else
                        return null;
                }
                else
                {
                    return null;
                }
            }
            else
                return null;
        }
    }       
}