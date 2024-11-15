namespace Calc4GH
{
    public partial class Form1 : Form
    {
        //bufor na to co zniknê³o z wyœwietlacza
        float buffer = 0;
        //zapamiêtana "zaleg³a" operacja
        char operation = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPressed(object sender, EventArgs e)
        {
            int number = int.Parse(((Button)sender).Text);
            displayTextBox.Text += number;
        }

        private void ClearDisplay(object sender, EventArgs e)
        {
            displayTextBox.Text = String.Empty;
            buffer = 0;
        }

        private void FunctionButtonPressed(object sender, EventArgs e)
        {
            //nie ma zaleg³ej operacji
            if (operation == ' ')
            {
                //przenosze zawartoœæ wyœwietlacza do bufora
                buffer = float.Parse(displayTextBox.Text);
                //czyszcze wyœwietlacz
                displayTextBox.Text = String.Empty;
                //zapisuje operacje do wykonania
                operation = ((Button)sender).Text[0];
            }
            else //jest zakolejkowana operacja
            {
                //dodaj do tego co juz jest w pamieci
                buffer += float.Parse(displayTextBox.Text);
                displayTextBox.Text = buffer.ToString();
                operation = ((Button)sender).Text[0];
            }
        }

        private void ShowResult(object sender, EventArgs e)
        {
            buffer += float.Parse(displayTextBox.Text);
            displayTextBox.Text = buffer.ToString();
        }
    }
}
