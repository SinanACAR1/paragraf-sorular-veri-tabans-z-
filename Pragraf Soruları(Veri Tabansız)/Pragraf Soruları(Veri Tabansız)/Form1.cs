using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;
        int doğru = 0;
        int yanlış = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button1.Text = "İLERİ";
            soruno++;
            label4.Text = soruno.ToString();
            lblsorununcevabı.Visible = false;
            label7.Visible = false;

            if (soruno == 1)
            {
                richTextBox1.Text = "1. Edebiyat; hava gibi, su gibi, güneş gibi, toprak gibi vazgeçilmezdi. Onunla yatılıp onunla kalkılıyordu ve yaratıcı gücünün sonsuzluğuna, edebiyatın insanı insan yapma büyüsüne İnanılıyordu. Toplumun yozlaşmaya ve her şeyin parayla ölçüldüğü, bilgi ve kültüre duyulan saygının, kredi kartlarına, görselliğe yönelmeye başladığı yıllarda, edebiyat 'Bir işlevi yok.' düşüncesiyle gazetelerden kovuldu. Edebiyat kovulunca da gazeteler çirkinleşti, gazetelerle birlikte dil de espri de düşünce de sığlaşıp yüceliğini yitirdi.";
                button2.Text = "Ticari bir getirişi olmadığı gerekçesiyle gazetelerden uzaklaştırıldığına";
                button3.Text = " Bir zamanlar yaşamın her alanında varlığını hissettirdiğine";
                button4.Text = "Kendini yenileyemediği İçin ilgi görmediğine";
                button5.Text = " İkinci plana itildiği için, dil, düşünce ve espri kalitesinin düştüğüne";
                button6.Text = "Ticari zihniyetin egemen olmaya başla­masıyla etkisini yitirdiğine";
                lblsorununcevabı.Text = "Kendini yenileyemediği İçin ilgi görmediğine";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Türkçe benim biricik vatanım, memleketim, evim. Nereye gitsem, onu da beraberimde götürürüm. Ben Türkçeye tutkunum. Uzun yıllar Fransızca öğretmenliği yaptım. Fransızcayı da çok rahat konuşurum. Biraz İngilizce okudum, derken dört yıl İtalyanca kurslarına gittim, İtalyanca öğrendim. Bir parçacık da Almancaya el attım. Ama benim için Türkçenin yeri başka. Her insan kendi dilini sever; ama bence Türkçe dünya dillerinin en güzellerinden biri.";
                button2.Text = " Yabancı dil öğrenmeye yatkın olma";
                button3.Text = "Bir zamanlar yaşamın her alanında varlığını hissettirdiğine";
                button4.Text = "Kendini yenileyemediği İçin ilgi görmediğine";
                button5.Text = "İkinci plana itildiği için, dil, düşünce ve espri kalitesinin düştüğüne";
                button6.Text = "Ticari zihniyetin egemen olmaya başla­masıyla etkisini yitirdiğine";
                lblsorununcevabı.Text = "Ticari zihniyetin egemen olmaya başla­masıyla etkisini yitirdiğine";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Gülhane Hayvanat Bahçesi'ne herkes gibi ilk olarak ailece gitmiştik. Zürafayı ve maymunları çok iyi hatırlıyorum. Alay Köşkü'nü uzun uzun incelemiş ve sonra parkın serinliğine kendimi bırakmıştım. Ama bu geziden bir türlü mutlu olamamıştım. Pislik içindeki küçük kafeslerinde sinir hastası olmuş aslanlar, maymunlar, domuzlar ve kediler görmekten içim daralmıştı. Her yer dışkı kokuyor ve her yer kaybedilen özgürlüğün ağıtını söylüyordu.Bu parçada dile getirilmek istenen duygu ya da davranış aşağıdakilerden hangisidir?";
                button2.Text = "Pişmanlık";
                button3.Text = "Şaşırma";
                button4.Text = "Düş kırıklığına uğrama";
                button5.Text = "Umursamama";
                button6.Text = "Utanç duyma";
                lblsorununcevabı.Text = "Düş kırıklığına uğrama";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = " Resimde ele alınan konu çok çeşitli olabilir. (II) Sanatçı doğayı, sosyal, dini ya da ideolojik bir temayı, bilineni ya da bilinmeyeni ele alıp tuvaline taşıyabilir. (Ill) Zaten böyle bir özgürlüğe sahip değilse üretmiş olduğu eserin, sanat değeri taşıyıp taşımadığı tartışılır. (IV) Önemli olan sanatçının eserinde kendini anlatabilmesi, izleyenin eserde sanatçıyı görebilmesidir. (V) Bu nedenle konu, resmin temel öğelerinden biri değildir; sadece sanatçının iç dünyasını yüzeye aktarabilmesinde bir aracıdır.Bu parçada anlatılmak isteneni içeren en genel yargı numaralanmış cümlelerden hangisidir?";
                button2.Text = "I.";
                button3.Text = "II.";
                button4.Text = "III.";
                button5.Text = "IV";
                button6.Text = "V";
                lblsorununcevabı.Text = "V";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Benim hiçbir öykümde önceden belirlenmiş bir iskelet olmadı. Roman üzerinde istediğim zaman çalışabilmeme karşın, öykünün "+"eşref saati"+"ni beklemem gerekirdi hep. Masanın başına oturup "+"Biraz öykü çalışayım."+" diyemedim hiç. Buna kalkıştığımda ise altını imzalamayacağım çok kötü şeyler yazdığımı gördüm. ........Bu parçanın sonuna, düşüncenin akışına göre aşağıdakilerden hangisi getirilebilir?";
                button2.Text = " Roman, öykü gibi yazma süreci içinde oluşmuyor.";
                button3.Text = "Roman, yazarın duygu dünyasını hiçbir zaman öykü kadar yansıtamaz";
                button4.Text = "Öykünün iletisi, romanınki gibi baştan belli değildir";
                button5.Text = "Öyküyle romanın yazılma sürecindeki asıl fark bu bence.";
                button6.Text = "Öyküde olay ve kişi sayısı sınırlıdır, romana göre daha azdır.";
                lblsorununcevabı.Text = "Öyküyle romanın yazılma sürecindeki asıl fark bu bence.";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblsizincevabınız.Text = button5.Text;
            if (lblsizincevabınız.Text == lblsorununcevabı.Text)
            {
                MessageBox.Show("Doğru cevap");
                doğru++;
                label2.Text = doğru.ToString();
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                label7.Visible = true;
                lblsorununcevabı.Visible = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblsizincevabınız.Text = button4.Text;
            if (lblsizincevabınız.Text == lblsorununcevabı.Text)
            {
                MessageBox.Show("Doğru cevap");
                doğru++;
                label2.Text = doğru.ToString();
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                label7.Visible = true;
                lblsorununcevabı.Visible = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblsizincevabınız.Text = button3.Text;
            if (lblsizincevabınız.Text == lblsorununcevabı.Text)
            {
                MessageBox.Show("Doğru cevap");
                doğru++;
                label2.Text = doğru.ToString();
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                label7.Visible = true;
                lblsorununcevabı.Visible = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblsizincevabınız.Text = button2.Text;
            if (lblsizincevabınız.Text == lblsorununcevabı.Text)
            {
                MessageBox.Show("Doğru cevap");
                doğru++;
                label2.Text = doğru.ToString();
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                label7.Visible = true;
                lblsorununcevabı.Visible = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblsizincevabınız.Text = button6.Text;
            if (lblsizincevabınız.Text == lblsorununcevabı.Text)
            {
                MessageBox.Show("Doğru cevap");
                doğru++;
                label2.Text = doğru.ToString();
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                label7.Visible = true;
                lblsorununcevabı.Visible = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }
    }
}
