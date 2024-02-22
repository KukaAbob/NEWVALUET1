using System.Text.RegularExpressions;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using HtmlAgilityPack;
using OpenQA.Selenium.DevTools.V122.Storage;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace NEWVALUET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected IWebDriver Driver;


        public void Setup()
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void HideEdgeBrowserWindow()
        {
            // —крываем окно браузера Edge
            foreach (var process in Process.GetProcessesByName("msedgedriver"))
            {
                IntPtr mainWindowHandle = process.MainWindowHandle;
                ShowWindow(mainWindowHandle, SW_HIDE); // SW_HIDE скрывает окно
            }
        }

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_HIDE = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
            var edgeDriverPath = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedgedriver.exe";

/*открываетс€ edge веб браузер*/
            var edgeOptions = new EdgeOptions();
            edgeOptions.AddArgument("--headless"); /*headless типо убирает экран браузера*/

            Driver = new EdgeDriver(edgeDriverPath, edgeOptions);

            Driver.Navigate().GoToUrl("https://kase.kz/ru/shares/");

            HideEdgeBrowserWindow();

            /*ѕопробуй другой сайт тк этот требует куки которые блокуютс€*/
            
            IWebElement aboba = Driver.FindElement(By.CssSelector("#wrap > div.container > div > div:nth-child(3) > div.accordion__body > div:nth-child(1) > div:nth-child(2) > table > tbody > tr:nth-child(1) > td:nth-child(2)"));
            IWebElement abob = Driver.FindElement(By.CssSelector("#wrap > div.container > div > div:nth-child(3) > div.accordion__body > div:nth-child(1) > div:nth-child(2) > table > tbody > tr:nth-child(2) > td:nth-child(2) > span"));
            string Straboba = aboba.Text;
            string Jrabob = abob.Text;
            textBox2.Text = Straboba;
            textBox1.Text = Jrabob;

            string.IsNullOrWhiteSpace(Straboba);

            Driver.Navigate().GoToUrl("https://pomenyay.kz/?ref=xranks");

            IWebElement dollar = Driver.FindElement(By.XPath("/html/body/div[2]/div[1]/form/div/table/tbody/tr[1]/td[3]/div"));
            IWebElement euro = Driver.FindElement(By.XPath("/html/body/div[2]/div[1]/form/div/table/tbody/tr[1]/td[5]/div"));
            IWebElement veznoDerevanny = Driver.FindElement(By.XPath("/html/body/div[2]/div[1]/form/div/table/tbody/tr[1]/td[7]/div"));
            textBoxDollar.Text = dollar.Text;
            textBoxEuro.Text = euro.Text;
            textBoxRub.Text = veznoDerevanny.Text;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Text = textBox2.Text;
        }

        private void textBoxDollar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
