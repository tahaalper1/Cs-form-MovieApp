using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FİLM_UYGULAMA_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void jOHNWİCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            richTextBox1.Text = "John Wick, emekliye ayrılmış bir tetikçidir. Emekliliğinin tadını çıkarırken karısının yakalandığı amansız hastalıkla hayatı altüst olur. ... Artık kaybedecek hiçbir şeyi de kalmayan John Wick'in tek istediği intikamdır ve New York sokaklarında düşmanlarıyla nefes kesen bir kovalamacanın içine girer.";
            label3.Text = "7.4";
            label5.Text = "Keanu Reeves";
            label6.Text = "Chad Stahelski";
        }

        private void dEADPOLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Doktorların teşhisleri sonunda kanser olduğu ortaya çıkan Wade Wilson'ın (Ryan Reynolds) bilinen tedavi yöntemleri dahilinde hayatta kalma ihtimali yoktur. Ancak Weapon X adlı bir program, onu eskisinden daha iyi hale getirme vaadinde bulunur.";
            label3.Text = "8.0";
            label5.Text = "Ryan Reynolds";
            label6.Text = "Tim Miller";


        }

        private void hAYALADASIToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            richTextBox1.Text = "Hayal Adası, eğlenmek için bir adaya giden bir grup insanın yaşadıkları konu ediliyor. Bir grup insan, gönüllerince eğlenecekleri, hayallerindeki birçok şeyi gerçekleştirebilecekleri Fantasy Island'a gider. Fakat adada onları bekleyen düşlediklerinden oldukça farklıdır.";
            label3.Text = "4.9";
            label5.Text = "Michael Pena";
            label6.Text = "Jeff Wadlof";
        }

        private void tHEKİNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Shakespeare'in oyunundan uyarlanan The King filminde Hal, dikbaşlı bir prenstir. Aynı zamanda İngiltere tahtının da varisidir. Ancak tahta ve ailesine sırtını dönmüş, sıradan halkın arasında yaşamını sürdürüyordur. Tiran bir kral olan babası öldüğünde ise Kral Henry V olarak tahta geçmek zorunda kalır.";
            label3.Text = "7.2";
            label5.Text = "Timothee Chalamet";
            label6.Text = "David Michod";

         }

        private void aNNABELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Mia beklediği gibi hediyesi Annabelle'i görünce mutlu olur, ancak bu güzel anlar çok uzun sürmez. Form ailesinin evi bir gece evleri sapkın bir tarikat tarafından basılır ve ciddi bir saldırıya uğrarlar. ... Annabelle, yönetmenliğini James Wan'ın üstlendiği Korku Seansı filminin öncesini konu alıyor.";
            label3.Text = "5.4";
            label5.Text = "Ward Horton";
            label6.Text = "John Leonetti";
        }

        private void sAKSIOLMANINFAYDALARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Saksı Olmanın Faydaları,”The Perks Of Being Wallflower”, güler yüzlü bir bakış açısıyla, yaşamlarında travmalar bulunan ancak hayata tutunmaya kararlı, naif ve orta sınıftan gençlerin büyüme süreçlerini beyazperde’ye aktarıyor.";
            label3.Text = "8.0";
            label5.Text = "Logan Leman";
            label6.Text = "Stephen Chbosky";
        }

        private void aROGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Halı satıcısı Arif, kahramanlıklarıyla G.O.R.A. gezegeninde yalnızca dost edinmekle kalmaz, bol bol düşman da edinir.Yaptıkları yüzünden düşmanlarının gazabını hissetme zamanı gelmiştir. Komutan Logar Arif'i bir zaman makinesiyle 1 Milyon yıl geriye, taş devrine ışınlar.";
            label3.Text = "7.3";
            label5.Text = "Cem Yılmaz";
            label6.Text = "Ali Taner Baltacı";
        }

        private void ıSSIZADAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Issız Adam, yönetmenliğini Çağan Irmak'ın yaptığı 2008 yapımı Türk melodram sinema filmi. Başrollerini Melis Birkan ve Cemal Hünal'ın paylaştığı film, Alper adlı bir aşçı ile çocuk kostümleri tasarlayıp dikmekle uğraşan Ada adlı genç bir kızın aşklarının özelinde modern yaşamın insanları nasıl yalnızlaştırdığı anlatır.";
            label3.Text = "6.8";
            label5.Text = "Melis Birkan - Cemal Hünal";
            label6.Text = "Çağan Irmak";
        }
    }
}
