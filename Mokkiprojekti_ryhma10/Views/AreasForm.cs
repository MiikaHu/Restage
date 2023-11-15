using Mokkiprojekti_ryhma10.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkiprojekti_ryhma10.Views
{
    public partial class AreasForm : Form
    {

        CottageContext _db = new CottageContext();
       
        public AreasForm()
        {
            InitializeComponent();
            dgvAreas.DataSource = _db.Areas.ToList();
        }
        private void RefreshView()
        {
            dgvAreas.DataSource = _db.Areas.ToList();
            ClearForm();
        }
        private void ClearForm()
        {
            dgvAreas.ClearSelection();
            tbID_Areas.Text = "";
            tbName_Areas.Text = "";
        }
        private void btnCreateNew_Areas_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AreasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Area? selectedArea = dgvAreas.SelectedOrNull<Area>();
            if (MessageBox.Show("Are you sure you want to delete area " + selectedArea.Name, "Delete area?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (selectedArea != null)
                {
                    _db.Areas.Remove(selectedArea);
                    _db.SaveChanges();
                    RefreshView();
                }
            }
        }

        private void btnSave_Areas_Click(object sender, EventArgs e)
        {
            try
            {
                bool IDFilled = long.TryParse(tbID_Areas.Text, out long _);
                if (IDFilled)
                {
                    Area areaToModify = dgvAreas.SelectedOrNull<Area>();
                    areaToModify.AreaId = long.Parse(tbID_Areas.Text);
                    areaToModify.Name = tbName_Areas.Text.NullIfWhiteSpace();
                }
                else if (dgvAreas.SelectedRows.Count == 0) //TODO - TÄMÄ JOKA FORMILLE JA CREATE NEW NAPPI CLEARIKS
                {
                    Area newArea = new Area()
                    {
                        Name = tbName_Areas.Text.NullIfWhiteSpace(),
                        AreaId = long.Parse(tbID_Areas.Text),
                    }; _db.Areas.Add(newArea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            _db.SaveChanges();
            RefreshView();
        }

        private void dgvAreas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Area? selectedArea = dgvAreas.SelectedOrNull<Area>();
                if (selectedArea != null)
                {
                    tbID_Areas.Text = selectedArea.AreaId.ToString();
                    tbName_Areas.Text = selectedArea.Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDiscard_Areas_Click(object sender, EventArgs e)
        {   
            Area? selectedArea = dgvAreas.SelectedOrNull<Area>();
            if (MessageBox.Show("Are you sure you want to discard changes for area " + selectedArea.Name, "Discard changes ? ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (selectedArea != null)
                    {
                        tbID_Areas.Text = selectedArea.AreaId.ToString();
                        tbName_Areas.Text = selectedArea.Name;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tbNameSearch_Areas_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbNameSearch_Areas.Text;
            try
            {
                StringComparison comparison = StringComparison.OrdinalIgnoreCase;
                dgvAreas.DataSource = _db.Areas.AsEnumerable()
                    .Where(area =>
                area.AreaId.ToString().Contains(searchValue, comparison) || area.Name.Contains(searchValue, comparison)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
