using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 手機
{
    public partial class Form6 : Form
    {
        public Form6(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        Form1 f1;
        minesweeper ms = new minesweeper();
        public int number = 1;
        public int which = 0;
        private void Form6_Load(object sender, EventArgs e)
        {
            user1.SizeMode = PictureBoxSizeMode.Zoom;
            user2.SizeMode = PictureBoxSizeMode.Zoom;
            user3.SizeMode = PictureBoxSizeMode.Zoom;
            user4.SizeMode = PictureBoxSizeMode.Zoom;
            siri1.SizeMode = PictureBoxSizeMode.Zoom;
            siri2.SizeMode = PictureBoxSizeMode.Zoom;
            siri3.SizeMode = PictureBoxSizeMode.Zoom;
            siri4.SizeMode = PictureBoxSizeMode.Zoom;
            user2.Hide();
            user3.Hide();
            user4.Hide();
            siri2.Hide();
            siri3.Hide();
            siri4.Hide();
            textbox2.Hide();
            textbox3.Hide();
            textbox4.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 取消關閉作業
            Hide();          // 隱藏視窗e.Cancel = true; // 取消關閉作業
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && textbox2.Text != "")
            {
                textbox3.Enabled = true;
                siri3.Show();
                user3.Show();
                textbox3.Show();
                number++;

                if (textbox2.Text == "哈囉")
                {
                    label5.Show();
                    label6.Show();
                    label5.Text = "閉嘴";
                    label6.Text = "好嗎";
                }
                if (textbox2.Text == "過年去哪裡玩" || textbox2.Text == "假日去哪裡玩" || textbox2.Text == "下學期推薦的課" || textbox2.Text == "成大周圍好玩的" || textbox2.Text == "好玩的地方")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 4);
                    if (which == 3)
                    {
                        label5.Text = "高雄阿廢話";
                        label6.Text = "高雄發大財";

                    }
                    if (which == 0)
                    {
                        label5.Text = "好好待在家肥宅";
                        label6.Text = "玩電腦才會爽";

                    }
                    if (which == 1)
                    {
                        label5.Text = "台南好景點";
                        label6.Text = "來參考看看吧";
                        System.Diagnostics.Process.Start("https://decing.tw/tainan-travelall/");
                    }
                    if (which == 2)
                    {
                        label5.Text = "我覺得去台北阿";
                        label6.Text = "先進的都市呢";
                        System.Diagnostics.Process.Start("https://anrine910070.pixnet.net/blog/post/219962417-%E3%80%90%E5%8F%B0%E5%8C%97%E6%99%AF%E9%BB%9E%E6%8E%A8%E8%96%A6%E3%80%912019%E5%8F%B0%E5%8C%97%E4%B8%80%E6%97%A5%E9%81%8A%E5%A5%BD%E7%8E%A9%E8%A1%8C%E7%A8%8B%EF%BC%86");
                    }
                }
                if (textbox2.Text == "有什麼推薦的課嗎" || textbox2.Text == "推薦課程" || textbox2.Text == "下學期推薦的課" || textbox2.Text == "推薦什麼課" || textbox2.Text == "我想學習")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "那就要看你想學什麼囉";
                        label6.Text = "心得給你參考";
                        System.Diagnostics.Process.Start("https://nckuhub.com/");
                    }
                    if (which == 1)
                    {
                        label5.Text = "資工系視窗程式設計是個好課";
                        label6.Text = "希望你在其中有學到東西";

                    }
                    if (which == 2)
                    {
                        label5.Text = "我覺得你還是乖乖把必修好好修就好";
                        label6.Text = "都快被當了";
                    }
                }
                if (textbox2.Text == "我好熱" || textbox2.Text == "我好冷" || textbox2.Text == "今天好熱" || textbox2.Text == "今天好冷" || textbox2.Text == "天氣好熱")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "氣溫變化大";
                        label6.Text = "小心別感冒囉";

                    }
                    if (which == 1)
                    {
                        label5.Text = "所以...";
                        label6.Text = "跟我說幹嘛";

                    }
                    if (which == 2)
                    {
                        label5.Text = "近期天氣變化如下";
                        label6.Text = "注意穿著喔";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                }
                if (textbox2.Text == "打架" || textbox2.Text == "你好醜" || textbox2.Text == "閉嘴" || textbox2.Text == "是在哈囉" || textbox2.Text == "不要吵")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "......";
                        label6.Text = "好";
                        this.Hide();
                    }
                    if (which == 1)
                    {
                        label5.Text = "你是想被打是不是";
                        label6.Text = "現在小孩真欠揍";

                    }
                    if (which == 2)
                    {
                        label5.Text = "你好醜";
                        label6.Text = "你全家都醜";

                    }
                }
                if (textbox2.Text == "推薦電影" || textbox2.Text == "好看電影" || textbox2.Text == "近期好看電影" || textbox2.Text == "推薦好看電影" || textbox2.Text == "有什麼近期電影嗎")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "我覺得你應該要去讀書";
                        label6.Text = "小心被21";
                    }
                    if (which == 1)
                    {
                        label5.Text = "最近推薦電影如這個網站";
                        label6.Text = "";
                        System.Diagnostics.Process.Start("http://www.atmovies.com.tw/movie/next/");
                    }
                    if (which == 2)
                    {
                        label5.Text = "我覺得鋒回路轉很好看";
                        label6.Text = "推薦你去看一下";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=NDbOXPFRS6Q");
                    }
                }
                if (textbox2.Text == "要怎麼脫魯" || textbox2.Text == "如何脫魯" || textbox2.Text == "我想交女朋友" || textbox2.Text == "不想一個人過聖誕節" || textbox2.Text == "怎麼樣脫魯" || textbox2.Text == "如何脫魯")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "其實我覺得 我也不錯啊";
                        label6.Text = "可以跟我再一起 我會陪你";
                    }
                    if (which == 1)
                    {
                        label5.Text = "我覺得可能是時機還沒到";
                        label6.Text = "這幾天對的人說不定就會出現了";
                    }
                    if (which == 2)
                    {
                        label5.Text = "跟你分享幾個交友軟體";
                        label6.Text = "希望你在上面找到你的另一半";
                        System.Diagnostics.Process.Start("https://www.shopback.com.tw/blog/popular-dating-app-lists");
                    }
                }
                if (textbox2.Text == "哈囉" || textbox2.Text == "你好")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "你好";
                        label6.Text = "哈囉";
                    }
                    if (which == 1)
                    {
                        label5.Text = "今天天氣真棒";
                        label6.Text = "記得出去玩喔";
                    }
                    if (which == 2)
                    {
                        label5.Text = "新年快樂!";
                        label6.Text = "2020鼠年行大運";
                    }
                }
                else if (textbox2.Text == "google" || textbox2.Text == "我要查google" || textbox2.Text == "google搜尋" || textbox2.Text == "google查詢" || textbox2.Text == "查詢google")
                {
                    label5.Show();
                    label6.Show();
                    label5.Text = "好";
                    label6.Text = "";
                    System.Diagnostics.Process.Start("https://www.google.com");
                }
                else if (textbox2.Text == "facebook" || textbox2.Text == "我要登facebook" || textbox2.Text == "登入facebook" || textbox2.Text == "查詢facebook")
                {
                    label5.Show();
                    label6.Show();
                    label5.Text = "好";
                    label6.Text = "";
                    System.Diagnostics.Process.Start("https://www.facebook.com");
                }
                else if (textbox2.Text == "我失戀了" || textbox2.Text == "我好難過" || textbox2.Text == "我被當了" || textbox2.Text == "我今天出車禍")
                {
                    label5.Show();
                    label6.Show();
                    label5.Text = "苦難是人生的導師";
                    label6.Text = "推薦你這個網站  希望你心情好點";
                    System.Diagnostics.Process.Start("https://inbound.tw/writer/article/read/6824");
                }
                else if (textbox2.Text == "要怎麼交到女朋友" || textbox2.Text == "為什麼她不喜歡我" || textbox2.Text == "我覺得我對她很好 為什麼她還是這樣")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "我覺得你要照照鏡子";
                        label6.Text = "整形是可以考慮的";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 1)
                    {
                        label5.Text = "我覺得你值得更好的";
                        label6.Text = "這個交友網站推薦給你";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 2)
                    {
                        label5.Text = "怎麼了";
                        label6.Text = "你還好嗎";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                }
                else if (textbox2.Text == "午餐吃什麼呢" || textbox2.Text == "推薦午餐" || textbox2.Text == "推薦午餐有什麼" || textbox2.Text == "我肚子好餓" || textbox2.Text == "我想吃東西")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "育樂街啊";
                        label6.Text = "和你很適合";
                    }
                    if (which == 1)
                    {
                        label5.Text = "你為甚麼不問問";
                        label6.Text = "神奇谷歌呢";
                        System.Diagnostics.Process.Start("https://www.google.com");
                    }
                    if (which == 2)
                    {
                        label5.Text = "吃泡麵啦";
                        label6.Text = "簡單又快速";
                    }
                }
                else if (textbox2.Text == "你覺得我帥嗎" || textbox2.Text == "我是帥哥" || textbox2.Text == "我怎麼長得這麼帥" || textbox2.Text == "我每天被自己帥醒")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "我覺得你要照照鏡子";
                        label6.Text = "整形是可以考慮的";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 1)
                    {
                        label5.Text = "我覺得不行";
                        label6.Text = "路邊乞丐都比你帥";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 2)
                    {
                        label5.Text = "好啦";
                        label6.Text = "真的蠻帥的 有如金城武";
                        System.Diagnostics.Process.Start("https://www.google.com/search?q=%E9%87%91%E5%9F%8E%E6%AD%A6&sxsrf=ACYBGNS70GW7KYKgtjYn08H2LTnlEawbig:1577785496317&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiVmaiAzd_mAhUpzIsBHS32A74Q_AUoAXoECBIQAw&biw=1280&bih=610");
                    }
                }
                else if (textbox2.Text == "手機推薦什麼品牌" || textbox2.Text == "我想買手機" || textbox2.Text == "手機" || textbox2.Text == "我要買手機" || textbox2.Text == "買手機" || textbox2.Text == "手機推薦" || textbox2.Text == "有什麼推薦手機")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "apple 阿  畫質好效能快";
                        label6.Text = "還有siri";
                    }
                    if (which == 1)
                    {
                        label5.Text = "nokia 吧  體積小攜帶方便";
                        label6.Text = "雖然只能打電話";

                    }
                    if (which == 2)
                    {
                        label5.Text = "小米 oppo不錯啊";
                        label6.Text = "中國貨不用嗎";

                    }
                }
                else if (textbox2.Text == "我想睡覺" || textbox2.Text == "好累喔" || textbox2.Text == "辛苦工作一天真辛苦" || textbox2.Text == "我想念我的床" || textbox2.Text == "睡覺睡起來" || textbox2.Text == "我好累" || textbox2.Text == "好累")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "很累還在玩手機";
                        label6.Text = "去睡覺阿";
                    }
                    if (which == 1)
                    {
                        label5.Text = "充足睡眠才能有好體力";
                        label6.Text = "一天要睡滿八小時呢";

                    }
                    if (which == 2)
                    {
                        label5.Text = "休息是為了走更長遠的路";
                        label6.Text = "趕快洗澡睡覺吧";

                    }
                }
                else if (textbox2.Text == "你今天好嗎" || textbox2.Text == "你想我嗎" || textbox2.Text == "我好想你" || textbox2.Text == "你開心嗎" || textbox2.Text == "你快樂嗎" || textbox2.Text == "我覺得你看起來好累" || textbox2.Text == "你難過嗎")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "我很不開心 還要跟你講話";
                        label6.Text = "你不要吵好嗎";
                    }
                    if (which == 1)
                    {
                        label5.Text = "我好想你";
                        label6.Text = "可以多跟我聊天嘛";

                    }
                    if (which == 2)
                    {
                        label5.Text = "推薦你一些搞笑影片";
                        label6.Text = "就會變得跟我一樣開心喔";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=JdzY4NxbN-o");
                    }
                }
                else if (textbox2.Text == "總統投誰" || textbox2.Text == "總統大選要投誰" || textbox2.Text == "你覺得誰會當總統" || textbox2.Text == "韓國瑜好嗎" || textbox2.Text == "韓國瑜" || textbox2.Text == "我要投韓國瑜" || textbox2.Text == "總統大選要到了")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "記得去投票阿";
                        label6.Text = "投韓國瑜阿 韓國瑜萬歲";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=pd-v6TwYi0s");
                    }
                    if (which == 1)
                    {
                        label5.Text = "投蔡英文阿廢話";
                        label6.Text = "草包還敢選總統?";

                    }
                    if (which == 2)
                    {
                        label5.Text = "我覺得要看你自己";
                        label6.Text = "重點投票的時候不要亮票喔喔";

                    }
                }
                else if (textbox2.Text == "我想出國玩" || textbox2.Text == "要放寒假了ㄟ" || textbox2.Text == "寒假去哪裡玩" || textbox2.Text == "我要出去玩" || textbox2.Text == "出去玩" || textbox2.Text == "哪裡好玩" || textbox2.Text == "我想去旅遊")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "推薦日本";
                        label6.Text = "一個非常棒的地方喔喔";
                        System.Diagnostics.Process.Start("https://www.funtime.com.tw/package/%E6%97%A5%E6%9C%AC%E6%97%85%E9%81%8A");
                    }
                    if (which == 1)
                    {
                        label5.Text = "在家睡覺啦 還出去玩";
                        label6.Text = "出去玩不用錢??";

                    }
                    if (which == 2)
                    {
                        label5.Text = "我覺得台灣就很好玩了";
                        label6.Text = "去看看吧";
                        System.Diagnostics.Process.Start("https://www.funtime.com.tw/blog/funtime/%E3%80%90%E5%8F%B0%E7%81%A3%E6%97%85%E9%81%8A%E6%99%AF%E9%BB%9E%E6%8E%A8%E8%96%A6%E3%80%9110%E5%A4%A7%E3%80%8C%E5%BF%98%E6%86%82%E6%99%AF%E9%BB%9E%E3%80%8D%EF%BC%8C%E8%AE%93%E4%BD%A0%E4%B8%80%E7%9E%AC");
                    }
                }
                else if (textbox2.Text == "今天天氣如何" || textbox2.Text == "今日氣溫" || textbox2.Text == "晚上會下雨嗎" || textbox2.Text == "明天早上會下雨嗎")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "不會自己看嗎";
                        label6.Text = "還有問你朋友  啊我忘了你沒朋友";
                    }
                    if (which == 1)
                    {
                        label5.Text = "天氣如這個網站";
                        label6.Text = "";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                    if (which == 2)
                    {
                        label5.Text = "我猜會下雨";
                        label6.Text = "但還是給你看看氣象";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                }
                else if (textbox2.Text == "幹" || textbox2.Text == "幹你娘" || textbox2.Text == "操你媽" || textbox2.Text == "Fuck" || textbox2.Text == "肏" || textbox2.Text == "韓國瑜")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "再罵髒話啊";
                        label6.Text = "小心我把截圖po社群";
                    }
                    if (which == 1)
                    {
                        label5.Text = "不要自己罵自己";
                        label6.Text = "混帳東西";
                    }
                    if (which == 2)
                    {
                        label5.Text = "你好兇喔";
                        label6.Text = "哭給你看喔";
                    }
                }
                else if (textbox2.Text == "期末爆掉了" || textbox2.Text == "要被二一了" || textbox2.Text == "這科過的了嗎")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "沒關係";
                        label6.Text = "下學期努力就好";
                    }
                    if (which == 1)
                    {

                        label5.Text = "不要吵";
                        label6.Text = "我比你還慘";
                    }
                    if (which == 2)
                    {
                        label5.Text = "學霸笑你";
                        label6.Text = "叫我派大星教授加博士先生";
                    }
                }
                else if (textbox2.Text == "我想念書" || textbox2.Text == "我要認真了" || textbox2.Text == "我要拚了")
                {
                    Random random = new Random();
                    label5.Show();
                    label6.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label5.Text = "沒有用的";
                        label6.Text = "反正你等等就會開始混";
                    }
                    if (which == 1)
                    {
                        label5.Text = "先別管這個了";
                        label6.Text = "你聽過安...痾..踩地雷嗎";
                        ms.Show();
                    }
                    if (which == 2)
                    {
                        label5.Text = "那加油吧";
                        label6.Text = "聽點鋼琴樂如何";
                        System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=%E9%8B%BC%E7%90%B4");
                    }
                }
                else
                {
                    label5.Show();
                    label6.Show();
                    label5.Text = "不要吵";
                    label6.Text = "閉嘴";
                }
                textbox2.Enabled = false;
            }

        }

        private void textbox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && textbox3.Text != "")
            {
                textbox4.Enabled = true;
                siri4.Show();
                user4.Show();
                textbox4.Show();
                number++;
                if (textbox3.Text == "哈囉")
                {
                    label7.Show();
                    label8.Show();
                    label7.Text = "閉嘴";
                    label8.Text = "好嗎";
                }
                if (textbox3.Text == "過年去哪裡玩" || textbox3.Text == "假日去哪裡玩" || textbox3.Text == "下學期推薦的課" || textbox3.Text == "成大周圍好玩的" || textbox3.Text == "好玩的地方")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 4);
                    if (which == 3)
                    {
                        label7.Text = "高雄阿廢話";
                        label8.Text = "高雄發大財";

                    }
                    if (which == 0)
                    {
                        label7.Text = "好好待在家肥宅";
                        label8.Text = "玩電腦才會爽";

                    }
                    if (which == 1)
                    {
                        label7.Text = "台南好景點";
                        label8.Text = "來參考看看吧";
                        System.Diagnostics.Process.Start("https://decing.tw/tainan-travelall/");
                    }
                    if (which == 2)
                    {
                        label7.Text = "我覺得去台北阿";
                        label8.Text = "先進的都市呢";
                        System.Diagnostics.Process.Start("https://anrine910070.pixnet.net/blog/post/219962417-%E3%80%90%E5%8F%B0%E5%8C%97%E6%99%AF%E9%BB%9E%E6%8E%A8%E8%96%A6%E3%80%912019%E5%8F%B0%E5%8C%97%E4%B8%80%E6%97%A5%E9%81%8A%E5%A5%BD%E7%8E%A9%E8%A1%8C%E7%A8%8B%EF%BC%86");
                    }
                }
                if (textbox3.Text == "有什麼推薦的課嗎" || textbox3.Text == "推薦課程" || textbox3.Text == "下學期推薦的課" || textbox3.Text == "推薦什麼課" || textbox3.Text == "我想學習")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "那就要看你想學什麼囉";
                        label8.Text = "心得給你參考";
                        System.Diagnostics.Process.Start("https://nckuhub.com/");
                    }
                    if (which == 1)
                    {
                        label7.Text = "資工系視窗程式設計是個好課";
                        label8.Text = "希望你在其中有學到東西";

                    }
                    if (which == 2)
                    {
                        label7.Text = "我覺得你還是乖乖把必修好好修就好";
                        label8.Text = "都快被當了";
                    }
                }
                if (textbox3.Text == "我好熱" || textbox3.Text == "我好冷" || textbox3.Text == "今天好熱" || textbox3.Text == "今天好冷" || textbox3.Text == "天氣好熱")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "氣溫變化大";
                        label8.Text = "小心別感冒囉";

                    }
                    if (which == 1)
                    {
                        label7.Text = "所以...";
                        label8.Text = "跟我說幹嘛";

                    }
                    if (which == 2)
                    {
                        label7.Text = "近期天氣變化如下";
                        label8.Text = "注意穿著喔";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                }
                if (textbox3.Text == "打架" || textbox3.Text == "你好醜" || textbox3.Text == "閉嘴" || textbox3.Text == "是在哈囉" || textbox3.Text == "不要吵")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "......";
                        label8.Text = "好";
                        this.Hide();
                    }
                    if (which == 1)
                    {
                        label7.Text = "你是想被打是不是";
                        label8.Text = "現在小孩真欠揍";

                    }
                    if (which == 2)
                    {
                        label7.Text = "你好醜";
                        label8.Text = "你全家都醜";

                    }
                }
                if (textbox3.Text == "推薦電影" || textbox3.Text == "好看電影" || textbox3.Text == "近期好看電影" || textbox3.Text == "推薦好看電影" || textbox3.Text == "有什麼近期電影嗎")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "我覺得你應該要去讀書";
                        label8.Text = "小心被21";
                    }
                    if (which == 1)
                    {
                        label7.Text = "最近推薦電影如這個網站";
                        label8.Text = "";
                        System.Diagnostics.Process.Start("http://www.atmovies.com.tw/movie/next/");
                    }
                    if (which == 2)
                    {
                        label7.Text = "我覺得鋒回路轉很好看";
                        label8.Text = "推薦你去看一下";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=NDbOXPFRS6Q");
                    }
                }
                if (textbox3.Text == "要怎麼脫魯" || textbox3.Text == "如何脫魯" || textbox3.Text == "我想交女朋友" || textbox3.Text == "不想一個人過聖誕節" || textbox3.Text == "怎麼樣脫魯" || textbox3.Text == "如何脫魯")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "其實我覺得 我也不錯啊";
                        label8.Text = "可以跟我再一起 我會陪你";
                    }
                    if (which == 1)
                    {
                        label7.Text = "我覺得可能是時機還沒到";
                        label8.Text = "這幾天對的人說不定就會出現了";
                    }
                    if (which == 2)
                    {
                        label7.Text = "跟你分享幾個交友軟體";
                        label8.Text = "希望你在上面找到你的另一半";
                        System.Diagnostics.Process.Start("https://www.shopback.com.tw/blog/popular-dating-app-lists");
                    }
                }
                if (textbox3.Text == "哈囉" || textbox3.Text == "你好")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "你好";
                        label8.Text = "哈囉";
                    }
                    if (which == 1)
                    {
                        label7.Text = "今天天氣真棒";
                        label8.Text = "記得出去玩喔";
                    }
                    if (which == 2)
                    {
                        label7.Text = "新年快樂!";
                        label8.Text = "2020鼠年行大運";
                    }
                }
                else if (textbox3.Text == "google" || textbox3.Text == "我要查google" || textbox3.Text == "google搜尋" || textbox3.Text == "google查詢" || textbox3.Text == "查詢google")
                {
                    label7.Show();
                    label8.Show();
                    label7.Text = "好";
                    label8.Text = "";
                    System.Diagnostics.Process.Start("https://www.google.com");
                }
                else if (textbox3.Text == "facebook" || textbox3.Text == "我要登facebook" || textbox3.Text == "登入facebook" || textbox3.Text == "查詢facebook")
                {
                    label7.Show();
                    label8.Show();
                    label7.Text = "好";
                    label8.Text = "";
                    System.Diagnostics.Process.Start("https://www.facebook.com");
                }
                else if (textbox3.Text == "我失戀了" || textbox3.Text == "我好難過" || textbox3.Text == "我被當了" || textbox3.Text == "我今天出車禍")
                {
                    label7.Show();
                    label8.Show();
                    label7.Text = "苦難是人生的導師";
                    label8.Text = "推薦你這個網站  希望你心情好點";
                    System.Diagnostics.Process.Start("https://inbound.tw/writer/article/read/6824");
                }
                else if (textbox3.Text == "要怎麼交到女朋友" || textbox3.Text == "為什麼她不喜歡我" || textbox3.Text == "我覺得我對她很好 為什麼她還是這樣")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "我覺得你要照照鏡子";
                        label8.Text = "整形是可以考慮的";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 1)
                    {
                        label7.Text = "我覺得你值得更好的";
                        label8.Text = "這個交友網站推薦給你";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 2)
                    {
                        label7.Text = "怎麼了";
                        label8.Text = "你還好嗎";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                }
                else if (textbox3.Text == "午餐吃什麼呢" || textbox3.Text == "推薦午餐" || textbox3.Text == "推薦午餐有什麼" || textbox3.Text == "我肚子好餓" || textbox3.Text == "我想吃東西")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "育樂街啊";
                        label8.Text = "和你很適合";
                    }
                    if (which == 1)
                    {
                        label5.Text = "你為甚麼不問問";
                        label6.Text = "神奇谷歌呢";
                        System.Diagnostics.Process.Start("https://www.google.com");
                    }
                    if (which == 2)
                    {
                        label5.Text = "吃泡麵啦";
                        label6.Text = "簡單又快速";
                    }
                }
                else if (textbox3.Text == "你覺得我帥嗎" || textbox3.Text == "我是帥哥" || textbox3.Text == "我怎麼長得這麼帥" || textbox3.Text == "我每天被自己帥醒")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "我覺得你要照照鏡子";
                        label8.Text = "整形是可以考慮的";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 1)
                    {
                        label7.Text = "我覺得不行";
                        label8.Text = "路邊乞丐都比你帥";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 2)
                    {
                        label7.Text = "好啦";
                        label8.Text = "真的蠻帥的 有如金城武";
                        System.Diagnostics.Process.Start("https://www.google.com/search?q=%E9%87%91%E5%9F%8E%E6%AD%A6&sxsrf=ACYBGNS70GW7KYKgtjYn08H2LTnlEawbig:1577785496317&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiVmaiAzd_mAhUpzIsBHS32A74Q_AUoAXoECBIQAw&biw=1280&bih=610");
                    }
                }
                else if (textbox3.Text == "手機推薦什麼品牌" || textbox3.Text == "我想買手機" || textbox3.Text == "手機" || textbox3.Text == "我要買手機" || textbox3.Text == "買手機" || textbox3.Text == "手機推薦" || textbox3.Text == "有什麼推薦手機")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "apple 阿  畫質好效能快";
                        label8.Text = "還有siri";
                    }
                    if (which == 1)
                    {
                        label7.Text = "nokia 吧  體積小攜帶方便";
                        label8.Text = "雖然只能打電話";

                    }
                    if (which == 2)
                    {
                        label7.Text = "小米 oppo不錯啊";
                        label8.Text = "中國貨不用嗎";

                    }
                }
                else if (textbox3.Text == "我想睡覺" || textbox3.Text == "好累喔" || textbox3.Text == "辛苦工作一天真辛苦" || textbox3.Text == "我想念我的床" || textbox3.Text == "睡覺睡起來" || textbox3.Text == "我好累" || textbox3.Text == "好累")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "很累還在玩手機";
                        label8.Text = "去睡覺阿";
                    }
                    if (which == 1)
                    {
                        label7.Text = "充足睡眠才能有好體力";
                        label8.Text = "一天要睡滿八小時呢";

                    }
                    if (which == 2)
                    {
                        label7.Text = "休息是為了走更長遠的路";
                        label8.Text = "趕快洗澡睡覺吧";

                    }
                }
                else if (textbox3.Text == "你今天好嗎" || textbox3.Text == "你想我嗎" || textbox3.Text == "我好想你" || textbox3.Text == "你開心嗎" || textbox3.Text == "你快樂嗎" || textbox3.Text == "我覺得你看起來好累" || textbox3.Text == "你難過嗎")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "我很不開心 還要跟你講話";
                        label8.Text = "你不要吵好嗎";
                    }
                    if (which == 1)
                    {
                        label7.Text = "我好想你";
                        label8.Text = "可以多跟我聊天嘛";

                    }
                    if (which == 2)
                    {
                        label7.Text = "推薦你一些搞笑影片";
                        label8.Text = "就會變得跟我一樣開心喔";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=JdzY4NxbN-o");
                    }
                }
                else if (textbox3.Text == "總統投誰" || textbox3.Text == "總統大選要投誰" || textbox3.Text == "你覺得誰會當總統" || textbox3.Text == "韓國瑜好嗎" || textbox3.Text == "韓國瑜" || textbox3.Text == "我要投韓國瑜" || textbox3.Text == "總統大選要到了")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "記得去投票阿";
                        label8.Text = "投韓國瑜阿 韓國瑜萬歲";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=pd-v6TwYi0s");
                    }
                    if (which == 1)
                    {
                        label7.Text = "投蔡英文阿廢話";
                        label8.Text = "草包還敢選總統?";

                    }
                    if (which == 2)
                    {
                        label7.Text = "我覺得要看你自己";
                        label8.Text = "重點投票的時候不要亮票喔喔";

                    }
                }
                else if (textbox3.Text == "我想出國玩" || textbox3.Text == "要放寒假了ㄟ" || textbox3.Text == "寒假去哪裡玩" || textbox3.Text == "我要出去玩" || textbox3.Text == "出去玩" || textbox3.Text == "哪裡好玩" || textbox3.Text == "我想去旅遊")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "推薦日本";
                        label8.Text = "一個非常棒的地方喔喔";
                        System.Diagnostics.Process.Start("https://www.funtime.com.tw/package/%E6%97%A5%E6%9C%AC%E6%97%85%E9%81%8A");
                    }
                    if (which == 1)
                    {
                        label7.Text = "在家睡覺啦 還出去玩";
                        label8.Text = "出去玩不用錢??";

                    }
                    if (which == 2)
                    {
                        label7.Text = "我覺得台灣就很好玩了";
                        label8.Text = "去看看吧";
                        System.Diagnostics.Process.Start("https://www.funtime.com.tw/blog/funtime/%E3%80%90%E5%8F%B0%E7%81%A3%E6%97%85%E9%81%8A%E6%99%AF%E9%BB%9E%E6%8E%A8%E8%96%A6%E3%80%9110%E5%A4%A7%E3%80%8C%E5%BF%98%E6%86%82%E6%99%AF%E9%BB%9E%E3%80%8D%EF%BC%8C%E8%AE%93%E4%BD%A0%E4%B8%80%E7%9E%AC");
                    }
                }
                else if (textbox3.Text == "今天天氣如何" || textbox3.Text == "今日氣溫" || textbox3.Text == "晚上會下雨嗎" || textbox3.Text == "明天早上會下雨嗎")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "不會自己看嗎";
                        label8.Text = "還有問你朋友  啊我忘了你沒朋友";
                    }
                    if (which == 1)
                    {
                        label7.Text = "天氣如這個網站";
                        label8.Text = "";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                    if (which == 2)
                    {
                        label7.Text = "我猜會下雨";
                        label8.Text = "但還是給你看看氣象";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                }
                else if (textbox3.Text == "幹" || textbox3.Text == "幹你娘" || textbox3.Text == "操你媽" || textbox3.Text == "Fuck" || textbox3.Text == "肏" || textbox3.Text == "韓國瑜")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "再罵髒話啊";
                        label8.Text = "小心我把截圖po社群";
                    }
                    if (which == 1)
                    {
                        label7.Text = "不要自己罵自己";
                        label8.Text = "混帳東西";
                    }
                    if (which == 2)
                    {
                        label7.Text = "你好兇喔";
                        label8.Text = "哭給你看喔";
                    }
                }
                else if (textbox3.Text == "期末爆掉了" || textbox3.Text == "要被二一了" || textbox3.Text == "這科過的了嗎")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "沒關係";
                        label8.Text = "下學期努力就好";
                    }
                    if (which == 1)
                    {

                        label7.Text = "不要吵";
                        label8.Text = "我比你還慘";
                    }
                    if (which == 2)
                    {
                        label7.Text = "學霸笑你";
                        label8.Text = "叫我派大星教授加博士先生";
                    }
                }
                else if (textbox3.Text == "我想念書" || textbox3.Text == "我要認真了" || textbox3.Text == "我要拚了")
                {
                    Random random = new Random();
                    label7.Show();
                    label8.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label7.Text = "沒有用的";
                        label8.Text = "反正你等等就會開始混";
                    }
                    if (which == 1)
                    {
                        label7.Text = "先別管這個了";
                        label8.Text = "你聽過安...痾..踩地雷嗎";
                        ms.Show();
                    }
                    if (which == 2)
                    {
                        label7.Text = "那加油吧";
                        label8.Text = "聽點鋼琴樂如何";
                        System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=%E9%8B%BC%E7%90%B4");
                    }
                }
                else
                {
                    label7.Show();
                    label8.Show();
                    label7.Text = "不要吵";
                    label8.Text = "閉嘴";
                }
                textbox3.Enabled = false;
                textbox4.Text = "";
            }

        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && textbox1.Text != "")
            {
                label7.Hide();
                label8.Hide();
                textbox4.Text = "";
                siri2.Show();
                user2.Show();
                textbox2.Show();
                textbox2.Enabled = true;
                number++;
                if (textbox1.Text == "哈囉")
                {
                    label3.Show();
                    label4.Show();
                    label3.Text = "閉嘴";
                    label4.Text = "好嗎";
                }
                if (textbox1.Text == "過年去哪裡玩" || textbox1.Text == "假日去哪裡玩" || textbox1.Text == "下學期推薦的課" || textbox1.Text == "成大周圍好玩的" || textbox1.Text == "好玩的地方")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 4);
                    if (which == 3)
                    {
                        label3.Text = "高雄阿廢話";
                        label4.Text = "高雄發大財";

                    }
                    if (which == 0)
                    {
                        label3.Text = "好好待在家肥宅";
                        label4.Text = "玩電腦才會爽";

                    }
                    if (which == 1)
                    {
                        label3.Text = "台南好景點";
                        label4.Text = "來參考看看吧";
                        System.Diagnostics.Process.Start("https://decing.tw/tainan-travelall/");
                    }
                    if (which == 2)
                    {
                        label3.Text = "我覺得去台北阿";
                        label4.Text = "先進的都市呢";
                        System.Diagnostics.Process.Start("https://anrine910070.pixnet.net/blog/post/219962417-%E3%80%90%E5%8F%B0%E5%8C%97%E6%99%AF%E9%BB%9E%E6%8E%A8%E8%96%A6%E3%80%912019%E5%8F%B0%E5%8C%97%E4%B8%80%E6%97%A5%E9%81%8A%E5%A5%BD%E7%8E%A9%E8%A1%8C%E7%A8%8B%EF%BC%86");
                    }
                }
                if (textbox1.Text == "有什麼推薦的課嗎" || textbox1.Text == "推薦課程" || textbox1.Text == "下學期推薦的課" || textbox1.Text == "推薦什麼課" || textbox1.Text == "我想學習")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "那就要看你想學什麼囉";
                        label4.Text = "心得給你參考";
                        System.Diagnostics.Process.Start("https://nckuhub.com/");
                    }
                    if (which == 1)
                    {
                        label3.Text = "資工系視窗程式設計是個好課";
                        label4.Text = "希望你在其中有學到東西";

                    }
                    if (which == 2)
                    {
                        label3.Text = "我覺得你還是乖乖把必修好好修就好";
                        label4.Text = "都快被當了";
                    }
                }
                if (textbox1.Text == "我好熱" || textbox1.Text == "我好冷" || textbox1.Text == "今天好熱" || textbox1.Text == "今天好冷" || textbox1.Text == "天氣好熱")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "氣溫變化大";
                        label4.Text = "小心別感冒囉";

                    }
                    if (which == 1)
                    {
                        label3.Text = "所以...";
                        label4.Text = "跟我說幹嘛";

                    }
                    if (which == 2)
                    {
                        label3.Text = "近期天氣變化如下";
                        label4.Text = "注意穿著喔";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                }
                if (textbox1.Text == "打架" || textbox1.Text == "你好醜" || textbox1.Text == "閉嘴" || textbox1.Text == "是在哈囉" || textbox1.Text == "不要吵")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "......";
                        label4.Text = "好";
                        this.Hide();
                    }
                    if (which == 1)
                    {
                        label3.Text = "你是想被打是不是";
                        label4.Text = "現在小孩真欠揍";

                    }
                    if (which == 2)
                    {
                        label3.Text = "你好醜";
                        label4.Text = "你全家都醜";

                    }
                }
                if (textbox1.Text == "推薦電影" || textbox1.Text == "好看電影" || textbox1.Text == "近期好看電影" || textbox1.Text == "推薦好看電影" || textbox1.Text == "有什麼近期電影嗎")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "我覺得你應該要去讀書";
                        label4.Text = "小心被21";
                    }
                    if (which == 1)
                    {
                        label3.Text = "最近推薦電影如這個網站";
                        label4.Text = "";
                        System.Diagnostics.Process.Start("http://www.atmovies.com.tw/movie/next/");
                    }
                    if (which == 2)
                    {
                        label3.Text = "我覺得鋒回路轉很好看";
                        label4.Text = "推薦你去看一下";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=NDbOXPFRS6Q");
                    }
                }
                if (textbox1.Text == "要怎麼脫魯" || textbox1.Text == "如何脫魯" || textbox1.Text == "我想交女朋友" || textbox1.Text == "不想一個人過聖誕節" || textbox1.Text == "怎麼樣脫魯" || textbox1.Text == "如何脫魯")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "其實我覺得 我也不錯啊";
                        label4.Text = "可以跟我再一起 我會陪你";
                    }
                    if (which == 1)
                    {
                        label3.Text = "我覺得可能是時機還沒到";
                        label4.Text = "這幾天對的人說不定就會出現了";
                    }
                    if (which == 2)
                    {
                        label3.Text = "跟你分享幾個交友軟體";
                        label4.Text = "希望你在上面找到你的另一半";
                        System.Diagnostics.Process.Start("https://www.shopback.com.tw/blog/popular-dating-app-lists");
                    }
                }
                if (textbox1.Text == "哈囉" || textbox1.Text == "你好")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "你好";
                        label4.Text = "哈囉";
                    }
                    if (which == 1)
                    {
                        label3.Text = "今天天氣真棒";
                        label4.Text = "記得出去玩喔";
                    }
                    if (which == 2)
                    {
                        label3.Text = "新年快樂!";
                        label4.Text = "2020鼠年行大運";
                    }
                }
                else if (textbox1.Text == "google" || textbox1.Text == "我要查google" || textbox1.Text == "google搜尋" || textbox1.Text == "google查詢" || textbox1.Text == "查詢google")
                {
                    label3.Show();
                    label4.Show();
                    label3.Text = "好";
                    label4.Text = "";
                    System.Diagnostics.Process.Start("https://www.google.com");
                }
                else if (textbox1.Text == "facebook" || textbox1.Text == "我要登facebook" || textbox1.Text == "登入facebook" || textbox1.Text == "查詢facebook")
                {
                    label3.Show();
                    label4.Show();
                    label3.Text = "好";
                    label4.Text = "";
                    System.Diagnostics.Process.Start("https://www.facebook.com");
                }
                else if (textbox1.Text == "我失戀了" || textbox1.Text == "我好難過" || textbox1.Text == "我被當了" || textbox1.Text == "我今天出車禍")
                {
                    label3.Show();
                    label4.Show();
                    label3.Text = "苦難是人生的導師";
                    label4.Text = "推薦你這個網站  希望你心情好點";
                    System.Diagnostics.Process.Start("https://inbound.tw/writer/article/read/6824");
                }
                else if (textbox1.Text == "要怎麼交到女朋友" || textbox1.Text == "為什麼她不喜歡我" || textbox1.Text == "我覺得我對她很好 為什麼她還是這樣")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "我覺得你要照照鏡子";
                        label4.Text = "整形是可以考慮的";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 1)
                    {
                        label3.Text = "我覺得你值得更好的";
                        label4.Text = "這個交友網站推薦給你";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 2)
                    {
                        label3.Text = "怎麼了";
                        label4.Text = "你還好嗎";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                }
                else if (textbox1.Text == "午餐吃什麼呢" || textbox1.Text == "推薦午餐" || textbox1.Text == "推薦午餐有什麼" || textbox1.Text == "我肚子好餓" || textbox1.Text == "我想吃東西")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "育樂街啊";
                        label4.Text = "和你很適合";
                    }
                    if (which == 1)
                    {
                        label3.Text = "你為甚麼不問問";
                        label4.Text = "神奇谷歌呢";
                        System.Diagnostics.Process.Start("https://www.google.com");
                    }
                    if (which == 2)
                    {
                        label3.Text = "吃泡麵啦";
                        label4.Text = "簡單又快速";
                    }
                }
                else if (textbox1.Text == "你覺得我帥嗎" || textbox1.Text == "我是帥哥" || textbox1.Text == "我怎麼長得這麼帥" || textbox1.Text == "我每天被自己帥醒")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "我覺得你要照照鏡子";
                        label4.Text = "整形是可以考慮的";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 1)
                    {
                        label3.Text = "我覺得不行";
                        label4.Text = "路邊乞丐都比你帥";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 2)
                    {
                        label3.Text = "好啦";
                        label4.Text = "真的蠻帥的 有如金城武";
                        System.Diagnostics.Process.Start("https://www.google.com/search?q=%E9%87%91%E5%9F%8E%E6%AD%A6&sxsrf=ACYBGNS70GW7KYKgtjYn08H2LTnlEawbig:1577785496317&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiVmaiAzd_mAhUpzIsBHS32A74Q_AUoAXoECBIQAw&biw=1280&bih=610");
                    }
                }
                else if (textbox1.Text == "手機推薦什麼品牌" || textbox1.Text == "我想買手機" || textbox1.Text == "手機" || textbox1.Text == "我要買手機" || textbox1.Text == "買手機" || textbox1.Text == "手機推薦" || textbox1.Text == "有什麼推薦手機")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "apple 阿  畫質好效能快";
                        label4.Text = "還有siri";
                    }
                    if (which == 1)
                    {
                        label3.Text = "nokia 吧  體積小攜帶方便";
                        label4.Text = "雖然只能打電話";

                    }
                    if (which == 2)
                    {
                        label3.Text = "小米 oppo不錯啊";
                        label4.Text = "中國貨不用嗎";

                    }
                }
                else if (textbox1.Text == "我想睡覺" || textbox1.Text == "好累喔" || textbox1.Text == "辛苦工作一天真辛苦" || textbox1.Text == "我想念我的床" || textbox1.Text == "睡覺睡起來" || textbox1.Text == "我好累" || textbox1.Text == "好累")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "很累還在玩手機";
                        label4.Text = "去睡覺阿";
                    }
                    if (which == 1)
                    {
                        label3.Text = "充足睡眠才能有好體力";
                        label4.Text = "一天要睡滿八小時呢";

                    }
                    if (which == 2)
                    {
                        label3.Text = "休息是為了走更長遠的路";
                        label4.Text = "趕快洗澡睡覺吧";

                    }
                }
                else if (textbox1.Text == "你今天好嗎" || textbox1.Text == "你想我嗎" || textbox1.Text == "我好想你" || textbox1.Text == "你開心嗎" || textbox1.Text == "你快樂嗎" || textbox1.Text == "我覺得你看起來好累" || textbox1.Text == "你難過嗎")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "我很不開心 還要跟你講話";
                        label4.Text = "你不要吵好嗎";
                    }
                    if (which == 1)
                    {
                        label3.Text = "我好想你";
                        label4.Text = "可以多跟我聊天嘛";

                    }
                    if (which == 2)
                    {
                        label3.Text = "推薦你一些搞笑影片";
                        label4.Text = "就會變得跟我一樣開心喔";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=JdzY4NxbN-o");
                    }
                }
                else if (textbox1.Text == "總統投誰" || textbox1.Text == "總統大選要投誰" || textbox1.Text == "你覺得誰會當總統" || textbox1.Text == "韓國瑜好嗎" || textbox1.Text == "韓國瑜" || textbox1.Text == "我要投韓國瑜" || textbox1.Text == "總統大選要到了")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "記得去投票阿";
                        label4.Text = "投韓國瑜阿 韓國瑜萬歲";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=pd-v6TwYi0s");
                    }
                    if (which == 1)
                    {
                        label3.Text = "投蔡英文阿廢話";
                        label4.Text = "草包還敢選總統?";

                    }
                    if (which == 2)
                    {
                        label3.Text = "我覺得要看你自己";
                        label4.Text = "重點投票的時候不要亮票喔喔";

                    }
                }
                else if (textbox1.Text == "我想出國玩" || textbox1.Text == "要放寒假了ㄟ" || textbox1.Text == "寒假去哪裡玩" || textbox1.Text == "我要出去玩" || textbox1.Text == "出去玩" || textbox1.Text == "哪裡好玩" || textbox1.Text == "我想去旅遊")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "推薦日本";
                        label4.Text = "一個非常棒的地方喔喔";
                        System.Diagnostics.Process.Start("https://www.funtime.com.tw/package/%E6%97%A5%E6%9C%AC%E6%97%85%E9%81%8A");
                    }
                    if (which == 1)
                    {
                        label3.Text = "在家睡覺啦 還出去玩";
                        label4.Text = "出去玩不用錢??";

                    }
                    if (which == 2)
                    {
                        label3.Text = "我覺得台灣就很好玩了";
                        label4.Text = "去看看吧";
                        System.Diagnostics.Process.Start("https://www.funtime.com.tw/blog/funtime/%E3%80%90%E5%8F%B0%E7%81%A3%E6%97%85%E9%81%8A%E6%99%AF%E9%BB%9E%E6%8E%A8%E8%96%A6%E3%80%9110%E5%A4%A7%E3%80%8C%E5%BF%98%E6%86%82%E6%99%AF%E9%BB%9E%E3%80%8D%EF%BC%8C%E8%AE%93%E4%BD%A0%E4%B8%80%E7%9E%AC");
                    }
                }
                else if (textbox1.Text == "今天天氣如何" || textbox1.Text == "今日氣溫" || textbox1.Text == "晚上會下雨嗎" || textbox1.Text == "明天早上會下雨嗎")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "不會自己看嗎";
                        label4.Text = "還有問你朋友  啊我忘了你沒朋友";
                    }
                    if (which == 1)
                    {
                        label3.Text = "天氣如這個網站";
                        label4.Text = "";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                    if (which == 2)
                    {
                        label3.Text = "我猜會下雨";
                        label4.Text = "但還是給你看看氣象";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                }
                else if (textbox1.Text == "幹" || textbox1.Text == "幹你娘" || textbox1.Text == "操你媽" || textbox1.Text == "Fuck" || textbox1.Text == "肏" || textbox1.Text == "韓國瑜")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "再罵髒話啊";
                        label4.Text = "小心我把截圖po社群";
                    }
                    if (which == 1)
                    {
                        label3.Text = "不要自己罵自己";
                        label4.Text = "混帳東西";
                    }
                    if (which == 2)
                    {
                        label3.Text = "你好兇喔";
                        label4.Text = "哭給你看喔";
                    }
                }
                else if (textbox1.Text == "期末爆掉了" || textbox1.Text == "要被二一了" || textbox1.Text == "這科過的了嗎")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "沒關係";
                        label4.Text = "下學期努力就好";
                    }
                    if (which == 1)
                    {

                        label3.Text = "不要吵";
                        label4.Text = "我比你還慘";
                    }
                    if (which == 2)
                    {
                        label3.Text = "學霸笑你";
                        label4.Text = "叫我派大星教授加博士先生";
                    }
                }
                else if (textbox1.Text == "我想念書" || textbox1.Text == "我要認真了" || textbox1.Text == "我要拚了")
                {
                    Random random = new Random();
                    label3.Show();
                    label4.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label3.Text = "沒有用的";
                        label4.Text = "反正你等等就會開始混";
                    }
                    if (which == 1)
                    {
                        label3.Text = "先別管這個了";
                        label4.Text = "你聽過安...痾..踩地雷嗎";
                        ms.Show();
                    }
                    if (which == 2)
                    {
                        label3.Text = "那加油吧";
                        label4.Text = "聽點鋼琴樂如何";
                        System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=%E9%8B%BC%E7%90%B4");
                    }
                }
                else
                {
                    label3.Show();
                    label4.Show();
                    label3.Text = "不要吵";
                    label4.Text = "閉嘴";
                }
                textbox1.Enabled = false;

            }

        }

        private void textbox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void textbox4_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && textbox1.Text != "")
            {
                textbox1.Enabled = true;
                textbox1.Text = "";
                textbox2.Text = "";
                textbox3.Text = "";
                number++;
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                if (textbox4.Text == "哈囉")
                {
                    label1.Show();
                    label2.Show();
                    label1.Text = "閉嘴";
                    label2.Text = "好嗎";
                }
                if (textbox4.Text == "過年去哪裡玩" || textbox4.Text == "假日去哪裡玩" || textbox4.Text == "下學期推薦的課" || textbox4.Text == "成大周圍好玩的" || textbox4.Text == "好玩的地方")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 4);
                    if (which == 3)
                    {
                        label1.Text = "高雄阿廢話";
                        label2.Text = "高雄發大財";

                    }
                    if (which == 0)
                    {
                        label1.Text = "好好待在家肥宅";
                        label2.Text = "玩電腦才會爽";

                    }
                    if (which == 1)
                    {
                        label1.Text = "台南好景點";
                        label2.Text = "來參考看看吧";
                        System.Diagnostics.Process.Start("https://decing.tw/tainan-travelall/");
                    }
                    if (which == 2)
                    {
                        label1.Text = "我覺得去台北阿";
                        label2.Text = "先進的都市呢";
                        System.Diagnostics.Process.Start("https://anrine910070.pixnet.net/blog/post/219962417-%E3%80%90%E5%8F%B0%E5%8C%97%E6%99%AF%E9%BB%9E%E6%8E%A8%E8%96%A6%E3%80%912019%E5%8F%B0%E5%8C%97%E4%B8%80%E6%97%A5%E9%81%8A%E5%A5%BD%E7%8E%A9%E8%A1%8C%E7%A8%8B%EF%BC%86");
                    }
                }
                if (textbox4.Text == "有什麼推薦的課嗎" || textbox4.Text == "推薦課程" || textbox4.Text == "下學期推薦的課" || textbox4.Text == "推薦什麼課" || textbox4.Text == "我想學習")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "那就要看你想學什麼囉";
                        label2.Text = "心得給你參考";
                        System.Diagnostics.Process.Start("https://nckuhub.com/");
                    }
                    if (which == 1)
                    {
                        label1.Text = "資工系視窗程式設計是個好課";
                        label2.Text = "希望你在其中有學到東西";

                    }
                    if (which == 2)
                    {
                        label1.Text = "我覺得你還是乖乖把必修好好修就好";
                        label2.Text = "都快被當了";
                    }
                }
                if (textbox4.Text == "我好熱" || textbox4.Text == "我好冷" || textbox4.Text == "今天好熱" || textbox4.Text == "今天好冷" || textbox4.Text == "天氣好熱")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "氣溫變化大";
                        label2.Text = "小心別感冒囉";

                    }
                    if (which == 1)
                    {
                        label1.Text = "所以...";
                        label2.Text = "跟我說幹嘛";

                    }
                    if (which == 2)
                    {
                        label1.Text = "近期天氣變化如下";
                        label2.Text = "注意穿著喔";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                }
                if (textbox4.Text == "打架" || textbox4.Text == "你好醜" || textbox4.Text == "閉嘴" || textbox4.Text == "是在哈囉" || textbox4.Text == "不要吵")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "......";
                        label2.Text = "好";
                        this.Hide();
                    }
                    if (which == 1)
                    {
                        label1.Text = "你是想被打是不是";
                        label2.Text = "現在小孩真欠揍";

                    }
                    if (which == 2)
                    {
                        label1.Text = "你好醜";
                        label2.Text = "你全家都醜";

                    }
                }
                if (textbox4.Text == "推薦電影" || textbox4.Text == "好看電影" || textbox4.Text == "近期好看電影" || textbox4.Text == "推薦好看電影" || textbox4.Text == "有什麼近期電影嗎")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "我覺得你應該要去讀書";
                        label2.Text = "小心被21";
                    }
                    if (which == 1)
                    {
                        label1.Text = "最近推薦電影如這個網站";
                        label2.Text = "";
                        System.Diagnostics.Process.Start("http://www.atmovies.com.tw/movie/next/");
                    }
                    if (which == 2)
                    {
                        label1.Text = "我覺得鋒回路轉很好看";
                        label2.Text = "推薦你去看一下";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=NDbOXPFRS6Q");
                    }
                }
                if (textbox4.Text == "要怎麼脫魯" || textbox4.Text == "如何脫魯" || textbox4.Text == "我想交女朋友" || textbox4.Text == "不想一個人過聖誕節" || textbox4.Text == "怎麼樣脫魯" || textbox4.Text == "如何脫魯")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "其實我覺得 我也不錯啊";
                        label2.Text = "可以跟我再一起 我會陪你";
                    }
                    if (which == 1)
                    {
                        label1.Text = "我覺得可能是時機還沒到";
                        label2.Text = "這幾天對的人說不定就會出現了";
                    }
                    if (which == 2)
                    {
                        label1.Text = "跟你分享幾個交友軟體";
                        label2.Text = "希望你在上面找到你的另一半";
                        System.Diagnostics.Process.Start("https://www.shopback.com.tw/blog/popular-dating-app-lists");
                    }
                }
                if (textbox4.Text == "哈囉" || textbox4.Text == "你好")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "你好";
                        label2.Text = "哈囉";
                    }
                    if (which == 1)
                    {
                        label1.Text = "今天天氣真棒";
                        label2.Text = "記得出去玩喔";
                    }
                    if (which == 2)
                    {
                        label1.Text = "新年快樂!";
                        label2.Text = "2020鼠年行大運";
                    }
                }
                else if (textbox4.Text == "google" || textbox4.Text == "我要查google" || textbox4.Text == "google搜尋" || textbox4.Text == "google查詢" || textbox4.Text == "查詢google")
                {
                    label1.Show();
                    label2.Show();
                    label1.Text = "好";
                    label2.Text = "";
                    System.Diagnostics.Process.Start("https://www.google.com");
                }
                else if (textbox4.Text == "facebook" || textbox4.Text == "我要登facebook" || textbox4.Text == "登入facebook" || textbox4.Text == "查詢facebook")
                {
                    label1.Show();
                    label2.Show();
                    label1.Text = "好";
                    label2.Text = "";
                    System.Diagnostics.Process.Start("https://www.facebook.com");
                }
                else if (textbox4.Text == "我失戀了" || textbox4.Text == "我好難過" || textbox4.Text == "我被當了" || textbox4.Text == "我今天出車禍")
                {
                    label1.Show();
                    label2.Show();
                    label1.Text = "苦難是人生的導師";
                    label2.Text = "推薦你這個網站  希望你心情好點";
                    System.Diagnostics.Process.Start("https://inbound.tw/writer/article/read/6824");
                }
                else if (textbox4.Text == "要怎麼交到女朋友" || textbox4.Text == "為什麼她不喜歡我" || textbox4.Text == "我覺得我對她很好 為什麼她還是這樣")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "我覺得你要照照鏡子";
                        label2.Text = "整形是可以考慮的";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 1)
                    {
                        label1.Text = "我覺得你值得更好的";
                        label2.Text = "這個交友網站推薦給你";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 2)
                    {
                        label1.Text = "怎麼了";
                        label2.Text = "你還好嗎";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                }
                else if (textbox4.Text == "午餐吃什麼呢" || textbox4.Text == "推薦午餐" || textbox4.Text == "推薦午餐有什麼" || textbox4.Text == "我肚子好餓" || textbox4.Text == "我想吃東西")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "育樂街啊";
                        label2.Text = "和你很適合";
                    }
                    if (which == 1)
                    {
                        label1.Text = "你為甚麼不問問";
                        label2.Text = "神奇谷歌呢";
                        System.Diagnostics.Process.Start("https://www.google.com");
                    }
                    if (which == 2)
                    {
                        label1.Text = "吃泡麵啦";
                        label2.Text = "簡單又快速";
                    }
                }
                else if (textbox4.Text == "你覺得我帥嗎" || textbox4.Text == "我是帥哥" || textbox4.Text == "我怎麼長得這麼帥" || textbox4.Text == "我每天被自己帥醒")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "我覺得你要照照鏡子";
                        label2.Text = "整形是可以考慮的";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 1)
                    {
                        label1.Text = "我覺得不行";
                        label2.Text = "路邊乞丐都比你帥";
                        System.Diagnostics.Process.Start("https://www.facebook.com");
                    }
                    if (which == 2)
                    {
                        label1.Text = "好啦";
                        label2.Text = "真的蠻帥的 有如金城武";
                        System.Diagnostics.Process.Start("https://www.google.com/search?q=%E9%87%91%E5%9F%8E%E6%AD%A6&sxsrf=ACYBGNS70GW7KYKgtjYn08H2LTnlEawbig:1577785496317&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiVmaiAzd_mAhUpzIsBHS32A74Q_AUoAXoECBIQAw&biw=1280&bih=610");
                    }
                }
                else if (textbox4.Text == "手機推薦什麼品牌" || textbox4.Text == "我想買手機" || textbox4.Text == "手機" || textbox4.Text == "我要買手機" || textbox4.Text == "買手機" || textbox4.Text == "手機推薦" || textbox4.Text == "有什麼推薦手機")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "apple 阿  畫質好效能快";
                        label2.Text = "還有siri";
                    }
                    if (which == 1)
                    {
                        label1.Text = "nokia 吧  體積小攜帶方便";
                        label2.Text = "雖然只能打電話";

                    }
                    if (which == 2)
                    {
                        label1.Text = "小米 oppo不錯啊";
                        label2.Text = "中國貨不用嗎";

                    }
                }
                else if (textbox4.Text == "我想睡覺" || textbox4.Text == "好累喔" || textbox4.Text == "辛苦工作一天真辛苦" || textbox4.Text == "我想念我的床" || textbox4.Text == "睡覺睡起來" || textbox4.Text == "我好累" || textbox4.Text == "好累")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "很累還在玩手機";
                        label2.Text = "去睡覺阿";
                    }
                    if (which == 1)
                    {
                        label1.Text = "充足睡眠才能有好體力";
                        label2.Text = "一天要睡滿八小時呢";

                    }
                    if (which == 2)
                    {
                        label1.Text = "休息是為了走更長遠的路";
                        label2.Text = "趕快洗澡睡覺吧";

                    }
                }
                else if (textbox4.Text == "你今天好嗎" || textbox4.Text == "你想我嗎" || textbox4.Text == "我好想你" || textbox4.Text == "你開心嗎" || textbox4.Text == "你快樂嗎" || textbox4.Text == "我覺得你看起來好累" || textbox4.Text == "你難過嗎")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "我很不開心 還要跟你講話";
                        label2.Text = "你不要吵好嗎";
                    }
                    if (which == 1)
                    {
                        label1.Text = "我好想你";
                        label2.Text = "可以多跟我聊天嘛";

                    }
                    if (which == 2)
                    {
                        label1.Text = "推薦你一些搞笑影片";
                        label2.Text = "就會變得跟我一樣開心喔";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=JdzY4NxbN-o");
                    }
                }
                else if (textbox4.Text == "總統投誰" || textbox4.Text == "總統大選要投誰" || textbox4.Text == "你覺得誰會當總統" || textbox4.Text == "韓國瑜好嗎" || textbox4.Text == "韓國瑜" || textbox4.Text == "我要投韓國瑜" || textbox4.Text == "總統大選要到了")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "記得去投票阿";
                        label2.Text = "投韓國瑜阿 韓國瑜萬歲";
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=pd-v6TwYi0s");
                    }
                    if (which == 1)
                    {
                        label1.Text = "投蔡英文阿廢話";
                        label2.Text = "草包還敢選總統?";

                    }
                    if (which == 2)
                    {
                        label1.Text = "我覺得要看你自己";
                        label2.Text = "重點投票的時候不要亮票喔喔";

                    }
                }
                else if (textbox4.Text == "我想出國玩" || textbox4.Text == "要放寒假了ㄟ" || textbox4.Text == "寒假去哪裡玩" || textbox4.Text == "我要出去玩" || textbox4.Text == "出去玩" || textbox4.Text == "哪裡好玩" || textbox4.Text == "我想去旅遊")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "推薦日本";
                        label2.Text = "一個非常棒的地方喔喔";
                        System.Diagnostics.Process.Start("https://www.funtime.com.tw/package/%E6%97%A5%E6%9C%AC%E6%97%85%E9%81%8A");
                    }
                    if (which == 1)
                    {
                        label1.Text = "在家睡覺啦 還出去玩";
                        label2.Text = "出去玩不用錢??";

                    }
                    if (which == 2)
                    {
                        label1.Text = "我覺得台灣就很好玩了";
                        label2.Text = "去看看吧";
                        System.Diagnostics.Process.Start("https://www.funtime.com.tw/blog/funtime/%E3%80%90%E5%8F%B0%E7%81%A3%E6%97%85%E9%81%8A%E6%99%AF%E9%BB%9E%E6%8E%A8%E8%96%A6%E3%80%9110%E5%A4%A7%E3%80%8C%E5%BF%98%E6%86%82%E6%99%AF%E9%BB%9E%E3%80%8D%EF%BC%8C%E8%AE%93%E4%BD%A0%E4%B8%80%E7%9E%AC");
                    }
                }
                else if (textbox4.Text == "今天天氣如何" || textbox4.Text == "今日氣溫" || textbox4.Text == "晚上會下雨嗎" || textbox4.Text == "明天早上會下雨嗎")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "不會自己看嗎";
                        label2.Text = "還有問你朋友  啊我忘了你沒朋友";
                    }
                    if (which == 1)
                    {
                        label1.Text = "天氣如這個網站";
                        label2.Text = "";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                    if (which == 2)
                    {
                        label1.Text = "我猜會下雨";
                        label2.Text = "但還是給你看看氣象";
                        System.Diagnostics.Process.Start("https://www.cwb.gov.tw/V8/C/W/W50_index.html");
                    }
                }
                else if (textbox4.Text == "幹" || textbox4.Text == "幹你娘" || textbox4.Text == "操你媽" || textbox4.Text == "Fuck" || textbox4.Text == "肏" || textbox4.Text == "韓國瑜")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "再罵髒話啊";
                        label2.Text = "小心我把截圖po社群";
                    }
                    if (which == 1)
                    {
                        label1.Text = "不要自己罵自己";
                        label2.Text = "混帳東西";
                    }
                    if (which == 2)
                    {
                        label1.Text = "你好兇喔";
                        label2.Text = "哭給你看喔";
                    }
                }
                else if (textbox4.Text == "期末爆掉了" || textbox4.Text == "要被二一了" || textbox4.Text == "這科過的了嗎")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "沒關係";
                        label2.Text = "下學期努力就好";
                    }
                    if (which == 1)
                    {

                        label1.Text = "不要吵";
                        label2.Text = "我比你還慘";
                    }
                    if (which == 2)
                    {
                        label1.Text = "學霸笑你";
                        label2.Text = "叫我派大星教授加博士先生";
                    }
                }
                else if (textbox4.Text == "我想念書" || textbox4.Text == "我要認真了" || textbox4.Text == "我要拚了")
                {
                    Random random = new Random();
                    label1.Show();
                    label2.Show();
                    which = random.Next(0, 3);
                    if (which == 0)
                    {
                        label1.Text = "沒有用的";
                        label2.Text = "反正你等等就會開始混";
                    }
                    if (which == 1)
                    {
                        label1.Text = "先別管這個了";
                        label2.Text = "你聽過安...痾..踩地雷嗎";
                        ms.Show();
                    }
                    if (which == 2)
                    {
                        label1.Text = "那加油吧";
                        label2.Text = "聽點鋼琴樂如何";
                        System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=%E9%8B%BC%E7%90%B4");
                    }
                }
                else
                {
                    label1.Show();
                    label2.Show();
                    label1.Text = "不要吵";
                    label2.Text = "閉嘴";
                }
                textbox4.Enabled = false;
            }

        }

        private void user1_Click(object sender, EventArgs e)
        {

        }

        private void siri1_Click(object sender, EventArgs e)
        {

        }
    }
}
