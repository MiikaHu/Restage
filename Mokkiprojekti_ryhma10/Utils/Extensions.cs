using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti_ryhma10.Utils
{
    public static class Extensions
    {
        public static string? NullIfWhiteSpace(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) { return null; }
            return value;
        }

        public static T? SelectedOrNull<T>(this DataGridView dgv)
        {
            int selectedCellCount = dgv.SelectedRows.Count;
            if (selectedCellCount > 0)
            {
                return (T?)dgv.SelectedRows[0].DataBoundItem;
            }
            return default;
        }
    }
}
