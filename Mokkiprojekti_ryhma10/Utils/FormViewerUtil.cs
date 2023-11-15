namespace Mokkiprojekti_ryhma10
{
    internal class FormViewerUtil
    {
        // TODO Luokka staattiseksi, koska ei varmaan mitään syytä miksi näin ei olisi?
        public static void SwitchForm(Form formToHide, Form formToShow)
        {
            formToShow.Location = formToHide.Location;
            formToShow.StartPosition = FormStartPosition.Manual;

            // Add a handler for the FormClosed event so after formToShow is closed, automatically show the formToHide again
            formToShow.FormClosed += (_, e) =>
            {
                formToHide.Show();
            };

            formToShow.Show();
            formToHide.Hide();
        }
    }
}
