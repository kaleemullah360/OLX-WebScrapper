using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Require dependencies
Name:	ChromeDriver
ID:	WebDriver.ChromeDriver.win32
URL:	https://www.nuget.org/packages/WebDriver.ChromeDriver.win32/2.14.0

Name:	Selenium
ID:	Selenium.WebDriver
URL:	https://www.nuget.org/packages/Selenium.WebDriver/2.45.0
 */

/*well I am including over here */
using OpenQA.Selenium;
/* Chrome will do Perfect Job so adding it. :) */
using OpenQA.Selenium.Chrome;
/* Some File Writing */
using System.IO;
/* Xpath Lib */
using System.Xml.XPath;


namespace KU_MSCS14059_A1
{
    public partial class olx_html_scrapper_chrome : Form
    {
        public olx_html_scrapper_chrome()
        {
            InitializeComponent();
        }

        private void olx_html_scrapper_chrome_Load(object sender, EventArgs e)
        {

        }
        //user desktop path to store display files
        string path_Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //how many Pages ?
        public Int32 totalPages_Int = 0;
        public String default_Url = "";
        // well this is my main function I'll call it on Execute button press
        private void olx_html_scrapper_chrome_selenium(int totalPages_Int, String default_Url)
        {
            // Title, City, Price, Seller, Contact, Views
            var title_Str = "";
            var city_Str = "";
            var price_Str = "";
            var Seller_Str = "";
            var Contact_Str = "";
            var views_Str = "";

            /* initializing chrome driver */
            var chrome_Driver = ChromeDriverService.CreateDefaultService();
            //no need to show disturbing command window so set it hidden
            chrome_Driver.HideCommandPromptWindow = true;
            var chrome_Driver_Obj = new ChromeDriver(chrome_Driver, new ChromeOptions());
            //loop for main pages to desired number
            for (int pageNumber = 1; pageNumber <= totalPages_Int; pageNumber++)
            {
                /* load page url */
                chrome_Driver_Obj.Navigate().GoToUrl(default_Url + "?page=" + pageNumber);

                /* create a csv file for output*/
                File.WriteAllText(Path.Combine(path_Desktop, "Output_page_no_" + pageNumber + ".csv"), "Title, City, Price, Seller, Contact, Views \r\n");
                // each page contain 50 items and each item contains 1 item page urls so get only sub page url only
                var rows = chrome_Driver_Obj.FindElementsByXPath("//*[@id='offers_table']/tbody/tr/td/table/tbody");
                //main page contain 50 items so loop to 50
                for (int i = 0; i < rows.Count(); i++)
                {   // item urls page contains ulr of Product page.
                    var itemPageUrl = rows[i].FindElement(By.XPath(".//tr[1]/td[2]/h3/a")).GetAttribute("href");
                    //agian initialize driver and creat new object
                    var single_Page_Driver = new ChromeDriver(chrome_Driver, new ChromeOptions());
                    single_Page_Driver.Navigate().GoToUrl(itemPageUrl);
                    // subpage is only one so loop once only.
                    var rowsPage = single_Page_Driver.FindElementsByXPath("//*[@id='offer_active']/div[3]");
                    for (int j = 0; j < rowsPage.Count(); j++)
                    {   //get the results and put to file.
                        title_Str = rowsPage[j].FindElement(By.XPath(".//div[1]/div/div[1]/h1")).Text;
                        city_Str = rowsPage[j].FindElement(By.XPath(".//div[1]/div/div[1]/p/span[1]/span[2]/strong")).Text;
                        price_Str = rowsPage[j].FindElement(By.XPath(".//*[@id='offeractions']/div[1]/div[1]/div[1]/strong")).Text;
                        Seller_Str = rowsPage[j].FindElement(By.XPath(".//*[@id='offeractions']/div[1]/div[1]/div[2]/div/p/span[1]")).Text;
                        Contact_Str = rowsPage[j].FindElement(By.XPath(".//*[@id='contact_methods']/li[3]/div[2]/strong[1]")).Text;
                        views_Str = rowsPage[j].FindElement(By.XPath(".//*[@id='offerbottombar']/div/strong")).Text;


                        /* to output the result in textbox*/
                        progress_text_box.AppendText(title_Str.ToString().Trim() + "   " + city_Str.ToString().Trim() + " " + price_Str.ToString().Trim() + "  " + Seller_Str.ToString().Trim() + "   " + Contact_Str.ToString().Trim() + "  " + views_Str.ToString().Trim() + "\r\n");
                        /* add data to above 4 created csv file */
                        File.AppendAllText(Path.Combine(path_Desktop, "Output_page_no_" + pageNumber + ".csv"), title_Str.ToString().Trim().Replace(",", "") + "," + city_Str.ToString().Trim().Replace(",", "") + "," + price_Str.ToString().Trim().Replace(",", "") + "," + Seller_Str.ToString().Trim().Replace(",", "") + "," + Contact_Str.ToString().Trim().Replace(",", "") + "," + views_Str.ToString().Trim().Replace(",", "") + "\r\n");
                    }
                    single_Page_Driver.Quit();
                }

            }
            chrome_Driver_Obj.Quit();
        }


        private void btn_execute_Click(object sender, EventArgs e)
        {

            if (input_pages.Text.Equals(""))
            {
                MessageBox.Show("Pages field cannot be empty!");
            }
            else if (Int32.Parse(input_pages.Text).Equals(0))
            {
                MessageBox.Show("How can I compute Zero pages?");
            }
            else
            {
                if (url_text.Text.Equals(""))
                {
                    default_Url = "http://olx.com.pk/lahore/cars/";
                }
                else
                {
                    default_Url = url_text.Text;
                    totalPages_Int = Int32.Parse(input_pages.Text);
                    olx_html_scrapper_chrome_selenium(totalPages_Int, default_Url);
                }
            }

        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Confirm quit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void progress_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_pages_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string totalPages_Int = objTextBox.Text;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {

            Process.Start(path_Desktop);
        }

        private void url_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
