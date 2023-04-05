using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Class
{
    public class Notebooks
    {
        List<Notebook> notebooks = new List<Notebook>()
        {
            new Notebook("ASUS ROG Zephyrus G14","GA401IV-DS91"),
            new Notebook("Dell XPS 13","9310-94KN2"),
            new Notebook("HP Spectre x360","14-ea0023dx"),
            new Notebook("Lenovo ThinkPad X1 Carbon Gen 9","20XW003MUS"),
            new Notebook("Apple MacBook Pro 13-inch with M1 chip","MYD82LL/A"),
            new Notebook("Acer Swift 3","SF314-59-75QC"),
            new Notebook("Microsoft Surface Laptop 4","AMD Ryzen 7 Surface Edition"),
            new Notebook("Razer Blade 15 Base Model","RZ09-03287E22-R3U1"),
            new Notebook("MSI GS66 Stealth","10UG-075US"),
            new Notebook("Gigabyte Aero 15 OLED","XC-8US5130SP")
        };
        public List<Notebook> getAllNotebooks()
        {
            return notebooks;
        }
    }
}
