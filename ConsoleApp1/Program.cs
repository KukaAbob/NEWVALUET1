using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using HtmlAgilityPack;
using OpenQA.Selenium.DevTools.V122.Storage;
using System.Diagnostics;
using System.Runtime.InteropServices;
class Program
{

    protected IWebDriver driver;
    private EdgeDriver Driver;

    private void HideEdgeBrowserWindow()
    {
        // Скрываем окно браузера Edge
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
        var edgeDriverPath = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedgedriver.exe";

        // Инициализация браузера Edge
        var edgeOptions = new EdgeOptions();
        edgeOptions.AddArgument("--headless"); // Открывать браузер на весь экран

        Driver = new EdgeDriver(edgeDriverPath, edgeOptions);

        Driver.Navigate().GoToUrl("https://ru.investing.com/indices/kase-components");

        HideEdgeBrowserWindow();

        Driver.Quit();


        IWebElement mainNewsTitleElement = Driver.FindElement(By.CssSelector("//*[@id=\"pair_993130\"]/td[3]"));

        IWebElement valueee = mainNewsTitleElement;

        string text1 = valueee.Text;

        text1 = button1.Text;








        // Получаем текст заголовка
        string mainNewsTitle = mainNewsTitleElement.Text;

        // Проверяем, что заголовок не пустой
        string.IsNullOrWhiteSpace(mainNewsTitle);








        // Получаем текст заголовка
        string mainNewsTitle = mainNewsTitleElement.Text;

        // Проверяем, что заголовок не пустой
        string.IsNullOrWhiteSpace(mainNewsTitle);
    }
}
