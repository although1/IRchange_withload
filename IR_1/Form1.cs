using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace IR_1
{
    public partial class REMOTE_CODE_EDITOR : Form
    {
        public REMOTE_CODE_EDITOR()
        {
            InitializeComponent();
            MessageBox.Show("使用之前请先看使用说明");

        }

        //IR_NAME_1：将IR_NAME_TEXT的字符传递到button——generate
        public String IR_NAME_1
        {
            get { return IR_NAME_TEXT.Text; }
            set { IR_NAME_TEXT.Text = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //names的作用是生成.sh文件
            string[] names = new string[] { "#!/bin/bash\n",
            "customerpath=$1\n\n",
            "####first ir name\n", 
			"IR_PATH=./customer/$customerpath/tvconfig/config/IR/IR.ini\n\n",
			"rm -rf ${IR_PATH}\n\n\n\n",
            "IR_CONFIG_PATH=./vendor/mstar/kernel/mstar2/hal/messi/cpu/board/BD_GENERIC.h\n",
            "sed -i \"s/#define.*IR_TYPE_SEL.*/#define IR_TYPE_SEL IR_TYPE_SVT_RC05/g\" ${IR_CONFIG_PATH}\n",
            "IR_CONFIG_PATH=./vendor/mstar/mboot/sboot/inc/messi/board/BD_MST091B_10ASXG_15281_MESSI.h\n",
            "sed -i \"s/#define.*CUS_IR_HEAD_FILE.*/#define CUS_IR_HEAD_FILE \\x22IR_TYPE_SVT_RC05.h\\x22/g\" ${IR_CONFIG_PATH}\n",
            "IR_CONFIG_PATH=./vendor/mstar/pm/Zenonia/Project/Mstar/Source/cus_config.h\n",
            "sed -i \"s/#define.*CUS_IR_HEAD_FILE.*/#define CUS_IR_HEAD_FILE \\x22IR_TYPE_SVT_RC05.h\\x22/g\" ${IR_CONFIG_PATH}\n\n",
            "#########################################################ir key begin ################################################\n",
			"#############irkey linuxkey####linux key 16进制 max 0xffff, 十进制 max 9999   ()内部已空格隔开不能多空格 ##############\n\n",
			"#########################################################ir key end   ################################################\n\n",
            "IR_arr=\"\n",
            "[IR_VALUE]\n",
            "##############\n",
            "#ir name = IR_TYPE_YDG_GLD.ini\n",
            "#genrate ir path = /base/customer/ir_key/ydgconfig/tvconfig/config/IR/IR_TYPE_YDG_GLD.ini\n",
			"##############\n",
            "u8IR_Int[256] = { 0x",textBox1.Text,
            ", 0x",textBox2.Text,
            ", 0x",textBox3.Text,
            ", 0x",textBox4.Text,
            ", 0x",textBox5.Text,
            ", 0x",textBox6.Text,
            ", 0x",textBox7.Text,
            ", 0x",textBox8.Text,
            ", 0x",textBox9.Text,
            ", 0x",textBox10.Text,
            ", 0x",textBox11.Text,
            ", 0x",textBox12.Text,
            ", 0x",textBox13.Text,
            ", 0x",textBox14.Text,
            ", 0x",textBox15.Text,
            ", 0x",textBox16.Text,
            ", 0x",textBox17.Text,
            ", 0x",textBox18.Text,
            ", 0x",textBox19.Text,
            ", 0x",textBox20.Text,
            ", 0x",textBox21.Text,
            ", 0x",textBox22.Text,
            ", 0x",textBox23.Text,
            ", 0x",textBox24.Text,
            ", 0x",textBox25.Text,
            ", 0x",textBox26.Text,
            ", 0x",textBox27.Text,
            ", 0x",textBox28.Text,
            ", 0x",textBox29.Text,
            ", 0x",textBox30.Text,
            ", 0x",textBox31.Text,
            ", 0x",textBox32.Text,
            ", 0x",textBox33.Text,
            ", 0x",textBox34.Text,
            ", 0x",textBox35.Text,
            ", 0x",textBox36.Text,
            ", 0x",textBox37.Text,
            ", 0x",textBox38.Text,
            ", 0x",textBox39.Text,
            ", 0x",textBox40.Text,
            ", 0x",textBox41.Text,
            ", 0x",textBox42.Text,
            ", 0x",textBox43.Text,
            ", 0x",textBox44.Text,
            ", 0x",textBox45.Text,
            ", 0x",textBox46.Text,
            ", 0x",textBox47.Text,
            ", 0x",textBox48.Text,
            ", 0x",textBox49.Text,
            ", 0x",textBox50.Text,
            ", 0x",textBox51.Text,
            ", 0x",textBox52.Text,
            ", 0x",textBox53.Text,
            ", 0x",textBox54.Text,
            ", 0x",textBox55.Text,
            ", 0x",textBox56.Text,
            ", 0x",textBox57.Text,
            ", 0x",textBox58.Text,
            ", 0x",textBox59.Text,
            ", 0x",textBox60.Text,
            ", 0x",textBox61.Text,
            ", 0x",textBox62.Text,
            ", 0x",textBox63.Text,
            ", 0x",textBox64.Text,
            ", 0x",textBox65.Text,
            ", 0x",textBox66.Text,
            ", 0x",textBox67.Text,
            ", 0x",textBox68.Text,
            ", 0x",textBox69.Text,
            ", 0x",textBox70.Text,
            ", 0x",textBox71.Text,
            ", 0x",textBox72.Text,
            ", 0x",textBox73.Text,
            ", 0x",textBox74.Text,
            ", 0x",textBox75.Text,
            ", 0x",textBox76.Text,
            ", 0x",textBox77.Text,
            ", 0x",textBox78.Text,
            ", 0x",textBox79.Text,
            ", 0x",textBox80.Text,
            ", 0x",textBox81.Text,
            ", 0x",textBox82.Text,
            ", 0x",textBox83.Text,
            ", 0x",textBox84.Text,
            ", 0x",textBox85.Text,
            ", 0x",textBox86.Text,
            ", 0x",textBox87.Text,
            ", 0x",textBox88.Text,
            ", 0x",textBox89.Text,
            ", 0x",textBox90.Text,
            ", 0x",textBox91.Text,
            ", 0x",textBox92.Text,
            ", 0x",textBox93.Text,
            ", 0x",textBox94.Text,
            ", 0x",textBox95.Text,
            ", 0x",textBox96.Text,
            ", 0x",textBox97.Text,
            ", 0x",textBox98.Text,
            ", 0x",textBox99.Text,
            ", 0x",textBox100.Text,

            ", 0x",textBox101.Text,
            ", 0x",textBox102.Text,
            ", 0x",textBox103.Text,
            ", 0x",textBox104.Text,
            ", 0x",textBox105.Text,
            ", 0x",textBox106.Text,
            ", 0x",textBox107.Text,
            ", 0x",textBox108.Text,
            ", 0x",textBox109.Text,
            ", 0x",textBox110.Text,
            ", 0x",textBox111.Text,
            ", 0x",textBox112.Text,
            ", 0x",textBox113.Text,
            ", 0x",textBox114.Text,
            ", 0x",textBox115.Text,
            ", 0x",textBox116.Text,
            ", 0x",textBox117.Text,
            ", 0x",textBox118.Text,
            ", 0x",textBox119.Text,
            ", 0x",textBox120.Text,
            ", 0x",textBox121.Text,
            ", 0x",textBox122.Text,
            ", 0x",textBox123.Text,
            ", 0x",textBox124.Text,
            ", 0x",textBox125.Text,
            ", 0xFE, 0xFF, 0xFF, 0x88, 0x90, 0xFF, 0xFF, 0xFF, 0x04, 0x48, 0x49, 0x4D, 0x44, 0x45, 0x56, 0x01, 0x4A, 0x46, 0x50, 0x47, 0x57, 0x4B, 0x10, 0x02, 0x12, 0x06, 0x16, 0x03, 0x13, 0x07, 0x17, 0x00, 0x11, 0xFF, 0xFF, 0x05, 0xFF, 0x1E, 0xFF, 0x1C, 0x55, 0x41, 0xFF, 0x40, 0x51, 0xFF, 0x84, 0x86, 0xFF, 0x82, 0x81, 0x80, 0x85, 0xFF, 0x83, 0x14, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x59, 0xFF, 0x09, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xA7, 0x8F, 0x86, 0x8A, 0x8B, 0x8C, 0x84, 0x8D, 0x8E, 0x08, 0x18, 0x0C, 0x1D, 0xFF, 0x9C, 0x9D, 0x9E, 0xA3, 0x0E, 0x1A, 0xFF, 0x1B, 0x0F, 0x0B, 0x54, 0x0D, 0xFF, 0xFF, };\n\n",
            "[IR_KEY_CODE]\n",
            "u8IR_LINUX_KEY[256] = \\\n",
             "    { \\\n",
             "        0x2FF, 0x2FF, 0x2FF, 0x18B, 0x10C, 0x16B, 0x192, 0x193, 0x188, 0x073, 0x072, 0x067, 0x074, 0x09E, 0x08B, 0x06C,  \\\n",
             "        0x069, 0x01C, 0x06A, 0x00B, 0x002, 0x003, 0x004, 0x005, 0x006, 0x007, 0x008, 0x009, 0x00A, 0x071, 0x1D3, 0x2FF,  \\\n",
             "        0x166, 0x18E, 0x18F, 0x190, 0x191, 0x1D2, 0x1D4, 0x2FF, 0x04F, 0x0D4, 0x174, 0x0C6, 0x0C5, 0x2FF, 0x0C3, 0x0C1,  \\\n",
             "        0x0C0, 0x2FF, 0x2FF, 0x0E2, 0x2FF, 0x0A8, 0x09F, 0x0A5, 0x0A3, 0x0CF, 0x0A7, 0x080, 0x077, 0x08E, 0x16D, 0x066,  \\\n",
             "        0x10D, 0x10E, 0x2FF, 0x2FF, 0x2FF, 0x2FF, 0x040, 0x172, 0x2FF, 0x2FF, 0x03F,",
             " 0x",textBox151.Text,
             ", 0x",textBox152.Text,
             ", 0x",textBox153.Text,
             ", 0x",textBox154.Text,
             ", 0x",textBox155.Text,
             ",  \\\n",
             "        0x",textBox156.Text,
             ", 0x",textBox157.Text,
             ", 0x",textBox158.Text,
             ", 0x",textBox159.Text,
             ", 0x",textBox160.Text,
             ", 0x",textBox161.Text,
             ", 0x",textBox162.Text,
             ", 0x",textBox163.Text,
             ", 0x",textBox164.Text,
             ", 0x",textBox165.Text,
             ", 0x",textBox166.Text,
             ", 0x",textBox167.Text,
             ", 0x",textBox168.Text,
             ", 0x",textBox169.Text,
             ", 0x",textBox170.Text,
             ", 0x",textBox171.Text,
             ",  \\\n",
             "        0x",textBox172.Text,
             ", 0x",textBox173.Text,
             ", 0x",textBox174.Text,
             ", 0x",textBox175.Text,
             ", 0x081, 0x0BB, 0x0BD, 0x0BE, 0x0BF, 0x2FF, 0x0B7, 0x0B8, 0x0B9, 0x082, 0x083, 0x2FF,  \\\n",
             "        0x2FF, 0x2FF, 0x084, 0x085, 0x086, 0x087, 0x088, 0x082, 0x2FF, 0x08C, 0x08D, 0x089, 0x2FF, 0x2FF, 0x2FF, 0x2FF,  \\\n",
             "        0x2FF, 0x2FF",
             ", 0x0",textBox3.Text,
             ", 0x0",textBox4.Text,
             ", 0x0",textBox5.Text,
             ", 0x0",textBox6.Text,
             ", 0x0",textBox7.Text,
             ", 0x0",textBox8.Text,
             ", 0x0",textBox9.Text,
             ", 0x0",textBox10.Text,
             ", 0x0",textBox11.Text,
             ", 0x0",textBox12.Text,
             ", 0x0",textBox13.Text,
             ", 0x0",textBox14.Text,
             ", 0x0",textBox15.Text,
             ", 0x0",textBox16.Text,
             ",  \\\n",
             "        0x0",textBox17.Text,
             ", 0x0",textBox18.Text,
             ", 0x0",textBox19.Text,
             ", 0x0",textBox20.Text,
             ", 0x0",textBox21.Text,
             ", 0x0",textBox22.Text,
             ", 0x0",textBox23.Text,
             ", 0x0",textBox24.Text,
             ", 0x0",textBox25.Text,
             ", 0x0",textBox26.Text,
             ", 0x0",textBox27.Text,
             ", 0x0",textBox28.Text,
             ", 0x0",textBox29.Text,
             ", 0x0",textBox30.Text,
             ", 0x0",textBox31.Text,
             ", 0x0",textBox32.Text,
             ",  \\\n",
             "        0x0",textBox33.Text,
             ", 0x0",textBox34.Text,
             ", 0x0",textBox35.Text,
             ", 0x0",textBox36.Text,
             ", 0x0",textBox37.Text,
             ", 0x0",textBox38.Text,
             ", 0x0",textBox39.Text,
             ", 0x0",textBox40.Text,
             ", 0x0",textBox41.Text,
             ", 0x0",textBox42.Text,
             ", 0x0",textBox43.Text,
             ", 0x0",textBox44.Text,
             ", 0x0",textBox45.Text,
             ", 0x0",textBox46.Text,
             ", 0x0",textBox47.Text,
             ", 0x0",textBox48.Text,
             ",  \\\n",
             "        0x0",textBox49.Text,
             ", 0x0",textBox50.Text,
             ", 0x0",textBox51.Text,
             ", 0x0",textBox52.Text,
             ", 0x0",textBox53.Text,
             ", 0x0",textBox54.Text,
             ", 0x0",textBox55.Text,
             ", 0x0",textBox56.Text,
             ", 0x0",textBox57.Text,
             ", 0x0",textBox58.Text,
             ", 0x0",textBox59.Text,
             ", 0x0",textBox60.Text,
             ", 0x0",textBox61.Text,
             ", 0x0",textBox62.Text,
             ", 0x0",textBox63.Text,
             ", 0x0",textBox64.Text,
             ",  \\\n",
             "        0x0",textBox65.Text,
             ", 0x0",textBox66.Text,
             ", 0x0",textBox67.Text,
             ", 0x0",textBox68.Text,
             ", 0x0",textBox69.Text,
             ", 0x0",textBox70.Text,
             ", 0x0",textBox71.Text,
             ", 0x0",textBox72.Text,
             ", 0x0",textBox73.Text,
             ", 0x0",textBox74.Text,
             ", 0x0",textBox75.Text,
             ", 0x0",textBox76.Text,
             ", 0x0",textBox77.Text,
             ", 0x0",textBox78.Text,
             ", 0x0",textBox79.Text,
             ", 0x0",textBox80.Text,
             ",  \\\n",
             "        0x0",textBox81.Text,
             ", 0x0",textBox82.Text,
             ", 0x0",textBox83.Text,
             ", 0x0",textBox84.Text,
             ", 0x0",textBox85.Text,
             ", 0x0",textBox86.Text,
             ", 0x0",textBox87.Text,
             ", 0x0",textBox88.Text,
             ", 0x0",textBox89.Text,
             ", 0x0",textBox90.Text,
             ", 0x0",textBox91.Text,
             ", 0x0",textBox92.Text,
             ", 0x0",textBox93.Text,
             ", 0x0",textBox94.Text,
             ", 0x0",textBox95.Text,
             ", 0x0",textBox96.Text,
             ",  \\\n",
             "        0x0",textBox97.Text,
             ", 0x0",textBox98.Text,
             ", 0x0",textBox99.Text,
             ", 0x0",textBox100.Text,
             ", 0x0",textBox101.Text,
             ", 0x0",textBox102.Text,
             ", 0x0",textBox103.Text,
             ", 0x0",textBox104.Text,
             ", 0x0",textBox105.Text,
             ", 0x0",textBox106.Text,
             ", 0x0",textBox107.Text,
             ", 0x0",textBox108.Text,
             ", 0x0",textBox109.Text,
             ", 0x0",textBox110.Text,
             ", 0x0",textBox111.Text,
             ", 0x0",textBox112.Text,
             ",  \\\n",
             "        0x0",textBox113.Text,
             ", 0x0",textBox114.Text,
             ", 0x0",textBox115.Text,
             ", 0x0",textBox116.Text,
             ", 0x0",textBox117.Text,
             ", 0x0",textBox118.Text,
             ", 0x0",textBox119.Text,
             ", 0x0",textBox120.Text,
             ", 0x0",textBox121.Text,
             ", 0x0",textBox122.Text,
             ", 0x0",textBox123.Text,
             ", 0x0",textBox124.Text,
             ", 0x0",textBox125.Text,
             ", 0x0FE, 0x0FF, 0x0FF,  \\\n",
             "         \\\n",
             "    };\n\n",
             "\"\n\n",
            "touch ${IR_PATH}\n",
            "chmod 777 ${IR_PATH}\n",
            "echo \"${IR_arr}\" >${IR_PATH}\n\n\n",
             "############################generate u8IR_Int[256] = \n",
             "#tmp=0\n",
             "#outputstr=\n",
             "#rm -rf output.txt\n",
             "#for filename in `cat tmp.txt|grep \"IRKEY\"` ; do\n",
             "#    tmpname=$(echo ${filename}|cut -d '=' -f1)\n",
             "#	outputstr=\"${outputstr}\\${${tmpname}[1]}, \"\n",
             "#	tmp=$((tmp+1))\n",
             "#	if [ \"${tmp}\" == \"16\" ]; then\n",
             "#       tmp=0\n",
             "#	   outputstr=\"${outputstr} \\\\\\\\\"\n",
             "#	   echo ${outputstr}>>output.txt\n",
             "#	   outputstr=\n",
             "#	fi \n",
             "#	\n",
             "#done\n",
             "#if [ \"${outputstr}\" != \"\" ]; then\n",
             "#	   echo ${outputstr}>>output.txt\n",
             "#fi \n\n",
             "echo \"IR_TYPE_SVT_RC05 OK\"\n",
             "    \n",
            };
            using (StreamWriter sw = new StreamWriter(IR_NAME_1+".sh"))
            {
                foreach (string s in names)
                {
                    sw.Write(s);

                }
            }

            // 从文件中读取并显示每行
            string line = "";
            using (StreamReader sr = new StreamReader(IR_NAME_1 + ".sh"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.Write(line);
                }
            }
            /*
             * 以下注释的内容是在generate时，同时生成一个IR_YDG338.txt，方便导入，要配合LOAD使用
            //names_1的作用是生成IR_YDG338.txt
            string[] names_1 = new string[] {
            IR_NAME_TEXT.Text,"\n\n",
            "IRKEY_HEAD0 = ",textBox1.Text,"\n",
            "IRKEY_HEAD1 = ",textBox2.Text,"\n",
            "IRKEY_TV_ANTENNA = ",textBox3.Text,"\n",
            "IRKEY_CHANNEL_LIST = ",textBox4.Text,"\n",
            "IRKEY_CHANNEL_FAV_LIST = ",textBox5.Text,"\n",
            "IRKEY_CHANNEL_RETURN = ",textBox6.Text,"\n",
            "IRKEY_CHANNEL_PLUS = ",textBox7.Text,"\n",
            "IRKEY_CHANNEL_MINUS = ",textBox8.Text,"\n",
            "IRKEY_AUDIO = ",textBox9.Text,"\n",
            "IRKEY_VOLUME_PLUS = ",textBox10.Text,"\n",
            "IRKEY_VOLUME_MINUS = ",textBox11.Text,"\n",
            "IRKEY_UP = ",textBox12.Text,"\n",
            "IRKEY_POWER = ",textBox13.Text,"\n",
            "IRKEY_EXIT = ",textBox14.Text,"\n",
            "IRKEY_MENU = ",textBox15.Text,"\n",
            "IRKEY_DOWN = ",textBox16.Text,"\n",
            "IRKEY_LEFT = ",textBox17.Text,"\n",
            "IRKEY_SELECT = ",textBox18.Text,"\n",
            "IRKEY_RIGHT = ",textBox19.Text,"\n",
            "IRKEY_NUM_0 = ",textBox20.Text,"\n",
            "IRKEY_NUM_1 = ",textBox21.Text,"\n",
            "IRKEY_NUM_2 = ",textBox22.Text,"\n",
            "IRKEY_NUM_3 = ",textBox23.Text,"\n",
            "IRKEY_NUM_4 = ",textBox24.Text,"\n",
            "IRKEY_NUM_5 = ",textBox25.Text,"\n",
            "IRKEY_NUM_6 = ",textBox26.Text,"\n",
            "IRKEY_NUM_7 = ",textBox27.Text,"\n",
            "IRKEY_NUM_8 = ",textBox28.Text,"\n",
            "IRKEY_NUM_9 = ",textBox29.Text,"\n",
            "IRKEY_MUTE = ",textBox30.Text,"\n",
            "IRKEY_FREEZE = ",textBox31.Text,"\n",
            "IRKEY_CLOCK = ",textBox32.Text,"\n",
            "IRKEY_INFO = ",textBox33.Text,"\n",
            "IRKEY_RED = ",textBox34.Text,"\n",
            "IRKEY_GREEN = ",textBox35.Text,"\n",
            "IRKEY_YELLOW = ",textBox36.Text,"\n",
            "IRKEY_BLUE = ",textBox37.Text,"\n",
            "IRKEY_MTS = ",textBox38.Text,"\n",
            "IRKEY_TTX = ",textBox39.Text,"\n",
            "IRKEY_CC = ",textBox40.Text,"\n",
            "IRKEY_INPUT_SOURCE = ",textBox41.Text,"\n",
            "IRKEY_PICTURE = ",textBox42.Text,"\n",
            "IRKEY_ZOOM = ",textBox43.Text,"\n",
            "IRKEY_AV = ",textBox44.Text,"\n",
            "IRKEY_HDMI = ",textBox45.Text,"\n",
            "IRKEY_SCART = ",textBox46.Text,"\n",
            "IRKEY_PC = ",textBox47.Text,"\n",
            "IRKEY_DTV = ",textBox48.Text,"\n",
            "IRKEY_TV = ",textBox49.Text,"\n",
            "IRKEY_COMPONENT = ",textBox50.Text,"\n",
            "IRKEY_SV = ",textBox51.Text,"\n",
            "IRKEY_USB = ",textBox52.Text,"\n",
            "IRKEY_DASH = ",textBox53.Text,"\n",
            "IRKEY_BACKWARD = ",textBox54.Text,"\n",
            "IRKEY_FORWARD = ",textBox55.Text,"\n",
            "IRKEY_PREVIOUS = ",textBox56.Text,"\n",
            "IRKEY_NEXT = ",textBox57.Text,"\n",
            "IRKEY_PLAY = ",textBox58.Text,"\n",
            "IRKEY_RECORD = ",textBox59.Text,"\n",
            "IRKEY_STOP = ",textBox60.Text,"\n",
            "IRKEY_PAUSE = ",textBox61.Text,"\n",
            "IRKEY_SLEEP = ",textBox62.Text,"\n",
            "IRKEY_EPG = ",textBox63.Text,"\n",
            "IRKEY_HOME = ",textBox64.Text,"\n",
            "IRKEY_FAVORLIST_PLUS = ",textBox65.Text,"\n",
            "IRKEY_FAVORLIST_MINUS = ",textBox66.Text,"\n",
            "IRKEY_MIX = ",textBox67.Text,"\n",
            "IRKEY_INDEX = ",textBox68.Text,"\n",
            "IRKEY_HOLD = ",textBox69.Text,"\n",
            "IRKEY_SUBPAGE = ",textBox70.Text,"\n",
            "IRKEY_SUBCODE = ",textBox71.Text,"\n",
            "IRKEY_SUBTITLE = ",textBox72.Text,"\n",
            "IRKEY_TIME = ",textBox73.Text,"\n",
            "IRKEY_SIZE = ",textBox74.Text,"\n",
            "IRKEY_REVEAL = ",textBox75.Text,"\n",
            textBox126.Text," = ",textBox76.Text,"\n",
            textBox127.Text," = ",textBox77.Text,"\n",
            textBox128.Text," = ",textBox78.Text,"\n",
            textBox129.Text," = ",textBox79.Text,"\n",
            textBox130.Text," = ",textBox80.Text,"\n",
            textBox131.Text," = ",textBox81.Text,"\n",
            textBox132.Text," = ",textBox82.Text,"\n",
            textBox133.Text," = ",textBox83.Text,"\n",
            textBox134.Text," = ",textBox84.Text,"\n",
            textBox135.Text," = ",textBox85.Text,"\n",
            textBox136.Text," = ",textBox86.Text,"\n",
            textBox137.Text," = ",textBox87.Text,"\n",
            textBox138.Text," = ",textBox88.Text,"\n",
            textBox139.Text," = ",textBox89.Text,"\n",
            textBox140.Text," = ",textBox90.Text,"\n",
            textBox141.Text," = ",textBox91.Text,"\n",
            textBox142.Text," = ",textBox92.Text,"\n",
            textBox143.Text," = ",textBox93.Text,"\n",
            textBox144.Text," = ",textBox94.Text,"\n",
            textBox145.Text," = ",textBox95.Text,"\n",
            textBox146.Text," = ",textBox96.Text,"\n",
            textBox147.Text," = ",textBox97.Text,"\n",
            textBox148.Text," = ",textBox98.Text,"\n",
            textBox149.Text," = ",textBox99.Text,"\n",
            textBox150.Text," = ",textBox100.Text,"\n",
            "IRKEY_VOL100 = ",textBox101.Text,"\n",
            "IRKEY_COMPONENT2 = ",textBox102.Text,"\n",
            "IRKEY_HDMI1 = ",textBox103.Text,"\n",
            "IRKEY_HDMI2 = ",textBox104.Text,"\n",
            "IRKEY_HDMI3 = ",textBox105.Text,"\n",
            "IRKEY_HDMI4 = ",textBox106.Text,"\n",
            "IRKEY_AV1 = ",textBox107.Text,"\n",
            "IRKEY_AV2 = ",textBox108.Text,"\n",
            "IRKEY_AV3 = ",textBox109.Text,"\n",
            "IRKEY_F1 = ",textBox110.Text,"\n",
            "IRKEY_F2 = ",textBox111.Text,"\n",
            "IRKEY_F3 = ",textBox112.Text,"\n",
            "IRKEY_F4 = ",textBox113.Text,"\n",
            "IRKEY_F5 = ",textBox114.Text,"\n",
            "IRKEY_WIFI_TEST = ",textBox115.Text,"\n",
            "IRKEY_ETHER_TEST = ",textBox116.Text,"\n",
            "IRKEY_MAC_SHOW = ",textBox117.Text,"\n",
            "IRKEY_MAC_ERASE = ",textBox118.Text,"\n",
            "IRKEY_VERSION = ",textBox119.Text,"\n",
            "IRKEY_FACTORY_RESTORE = ",textBox120.Text,"\n",
            "IRKEY_AUTOSCAN = ",textBox121.Text,"\n",
            "IRKEY_PANEL1 = ",textBox122.Text,"\n",
            "IRKEY_PANEL2 = ",textBox123.Text,"\n",
            "IRKEY_BURNING = ",textBox124.Text,"\n",
            "IRKEY_ADJUST1 = ",textBox125.Text,"\n",
            };
            using (StreamWriter sw = new StreamWriter("IR_YDG338.txt"))
            {
                foreach (string s in names_1)
                {
                    sw.Write(s);

                }
            }

            // 从文件中读取并显示每行
            string line_1 = "";
            using (StreamReader sr = new StreamReader("IR_YDG338.txt"))
            {
                while ((line_1 = sr.ReadLine()) != null)
                {
                    Console.Write(line_1);
                }
            }
            */
            //Console.ReadKey();
            MessageBox.Show(IR_NAME_1 + ".sh was built" );
        }
        private void CODE_POWER_Load(object sender, EventArgs e)
        {

        }
        /*
         * 可以导入IR_YDG338.txt,要注意开头的格式，第一行是IR名称，第二行要空着，第三行才是头码开始，最后一行必须是IRKEY_ADJUST1
         * line1  IR_TYPE_SAM9012_0707_THREE_ACES
         * line2  
         * line3     IRKEY_HEAD0 = 07
         * line127   IRKEY_ADJUST1 = FD
                private void LOAD_Click(object sender, EventArgs e)
                {
                     StreamReader sr = File.OpenText("IR_YDG338.txt");
                    //StreamReader sr = new StreamReader(IR_NAME_1 + ".sh");
                    IR_NAME_TEXT.Text = sr.ReadLine();

                    string line = null;
                    int id = 0;
                    while ((!sr.EndOfStream) && ((line = sr.ReadLine()) != null))
                    {
                        Control[] controls = this.Controls.Find("textBox" + (id++).ToString(), true);
                        if ((controls == null)) continue;
                        foreach (Control control in controls)
                        {
                            int index = line.Length - 2; //长度大于2
                            if ((index >= 0) && (control is TextBox))
                                control.Text = line.Substring(index, 2);


                        }
                    }
                    sr.Dispose();
                }
        */
        private void Save_Click(object sender, EventArgs e)
        {
            //保存为.config
            AddUpdateAppSettings("IR_NAME", IR_NAME_TEXT.Text);
            AddUpdateAppSettings("IRKEY_HEAD0", textBox1.Text);
            AddUpdateAppSettings("IRKEY_HEAD1", textBox2.Text);
            AddUpdateAppSettings("IRKEY_TV_ANTENNA", textBox3.Text);
            AddUpdateAppSettings("IRKEY_CHANNEL_LIST", textBox4.Text);
            AddUpdateAppSettings("IRKEY_CHANNEL_FAV_LIST", textBox5.Text);
            AddUpdateAppSettings("IRKEY_CHANNEL_RETURN", textBox6.Text);
            AddUpdateAppSettings("IRKEY_CHANNEL_PLUS", textBox7.Text);
            AddUpdateAppSettings("IRKEY_CHANNEL_MINUS", textBox8.Text);
            AddUpdateAppSettings("IRKEY_AUDIO", textBox9.Text);
            AddUpdateAppSettings("IRKEY_VOLUME_PLUS", textBox10.Text);
            AddUpdateAppSettings("IRKEY_VOLUME_MINUS", textBox11.Text);
            AddUpdateAppSettings("IRKEY_UP", textBox12.Text);
            AddUpdateAppSettings("IRKEY_POWER", textBox13.Text);
            AddUpdateAppSettings("IRKEY_EXIT", textBox14.Text);
            AddUpdateAppSettings("IRKEY_MENU", textBox15.Text);
            AddUpdateAppSettings("IRKEY_DOWN", textBox16.Text);
            AddUpdateAppSettings("IRKEY_LEFT", textBox17.Text);
            AddUpdateAppSettings("IRKEY_SELECT", textBox18.Text);
            AddUpdateAppSettings("IRKEY_RIGHT", textBox19.Text);
            AddUpdateAppSettings("IRKEY_NUM_0", textBox20.Text);
            AddUpdateAppSettings("IRKEY_NUM_1", textBox21.Text);
            AddUpdateAppSettings("IRKEY_NUM_2", textBox22.Text);
            AddUpdateAppSettings("IRKEY_NUM_3", textBox23.Text);
            AddUpdateAppSettings("IRKEY_NUM_4", textBox24.Text);
            AddUpdateAppSettings("IRKEY_NUM_5", textBox25.Text);
            AddUpdateAppSettings("IRKEY_NUM_6", textBox26.Text);
            AddUpdateAppSettings("IRKEY_NUM_7", textBox27.Text);
            AddUpdateAppSettings("IRKEY_NUM_8", textBox28.Text);
            AddUpdateAppSettings("IRKEY_NUM_9", textBox29.Text);
            AddUpdateAppSettings("IRKEY_MUTE", textBox30.Text);
            AddUpdateAppSettings("IRKEY_FREEZE", textBox31.Text);
            AddUpdateAppSettings("IRKEY_CLOCK", textBox32.Text);
            AddUpdateAppSettings("IRKEY_INFO", textBox33.Text);
            AddUpdateAppSettings("IRKEY_RED", textBox34.Text);
            AddUpdateAppSettings("IRKEY_GREEN", textBox35.Text);
            AddUpdateAppSettings("IRKEY_YELLOW", textBox36.Text);
            AddUpdateAppSettings("IRKEY_BLUE", textBox37.Text);
            AddUpdateAppSettings("IRKEY_MTS", textBox38.Text);
            AddUpdateAppSettings("IRKEY_TTX", textBox39.Text);
            AddUpdateAppSettings("IRKEY_CC", textBox40.Text);
            AddUpdateAppSettings("IRKEY_INPUT_SOURCE", textBox41.Text);
            AddUpdateAppSettings("IRKEY_PICTURE", textBox42.Text);
            AddUpdateAppSettings("IRKEY_ZOOM", textBox43.Text);
            AddUpdateAppSettings("IRKEY_AV", textBox44.Text);
            AddUpdateAppSettings("IRKEY_HDMI", textBox45.Text);
            AddUpdateAppSettings("IRKEY_SCART", textBox46.Text);
            AddUpdateAppSettings("IRKEY_PC", textBox47.Text);
            AddUpdateAppSettings("IRKEY_DTV", textBox48.Text);
            AddUpdateAppSettings("IRKEY_TV", textBox49.Text);
            AddUpdateAppSettings("IRKEY_COMPONENT", textBox50.Text);
            AddUpdateAppSettings("IRKEY_SV", textBox51.Text);
            AddUpdateAppSettings("IRKEY_USB", textBox52.Text);
            AddUpdateAppSettings("IRKEY_DASH", textBox53.Text);
            AddUpdateAppSettings("IRKEY_BACKWARD", textBox54.Text);
            AddUpdateAppSettings("IRKEY_FORWARD", textBox55.Text);
            AddUpdateAppSettings("IRKEY_PREVIOUS", textBox56.Text);
            AddUpdateAppSettings("IRKEY_NEXT", textBox57.Text);
            AddUpdateAppSettings("IRKEY_PLAY", textBox58.Text);
            AddUpdateAppSettings("IRKEY_RECORD", textBox59.Text);
            AddUpdateAppSettings("IRKEY_STOP", textBox60.Text);
            AddUpdateAppSettings("IRKEY_PAUSE", textBox61.Text);
            AddUpdateAppSettings("IRKEY_SLEEP", textBox62.Text);
            AddUpdateAppSettings("IRKEY_EPG", textBox63.Text);
            AddUpdateAppSettings("IRKEY_HOME", textBox64.Text);
            AddUpdateAppSettings("IRKEY_FAVORLIST_PLUS", textBox65.Text);
            AddUpdateAppSettings("IRKEY_FAVORLIST_MINUS", textBox66.Text);
            AddUpdateAppSettings("IRKEY_MIX", textBox67.Text);
            AddUpdateAppSettings("IRKEY_INDEX", textBox68.Text);
            AddUpdateAppSettings("IRKEY_HOLD", textBox69.Text);
            AddUpdateAppSettings("IRKEY_SUBPAGE", textBox70.Text);
            AddUpdateAppSettings("IRKEY_SUBCODE", textBox71.Text);
            AddUpdateAppSettings("IRKEY_SUBTITLE", textBox72.Text);
            AddUpdateAppSettings("IRKEY_TIME", textBox73.Text);
            AddUpdateAppSettings("IRKEY_SIZE", textBox74.Text);
            AddUpdateAppSettings("IRKEY_REVEAL", textBox75.Text);
            AddUpdateAppSettings("IRKEY_NOUSE", textBox76.Text);
            AddUpdateAppSettings("IRKEY_NOUSE1", textBox77.Text);
            AddUpdateAppSettings("IRKEY_NOUSE2", textBox78.Text);
            AddUpdateAppSettings("IRKEY_NOUSE3", textBox79.Text);
            AddUpdateAppSettings("IRKEY_NOUSE4", textBox80.Text);
            AddUpdateAppSettings("IRKEY_NOUSE5", textBox81.Text);
            AddUpdateAppSettings("IRKEY_NOUSE6", textBox82.Text);
            AddUpdateAppSettings("IRKEY_NOUSE7", textBox83.Text);
            AddUpdateAppSettings("IRKEY_NOUSE8", textBox84.Text);
            AddUpdateAppSettings("IRKEY_NOUSE9", textBox85.Text);
            AddUpdateAppSettings("IRKEY_NOUSE10", textBox86.Text);
            AddUpdateAppSettings("IRKEY_NOUSE11", textBox87.Text);
            AddUpdateAppSettings("IRKEY_NOUSE12", textBox88.Text);
            AddUpdateAppSettings("IRKEY_NOUSE13", textBox89.Text);
            AddUpdateAppSettings("IRKEY_NOUSE14", textBox90.Text);
            AddUpdateAppSettings("IRKEY_NOUSE15", textBox91.Text);
            AddUpdateAppSettings("IRKEY_NOUSE16", textBox92.Text);
            AddUpdateAppSettings("IRKEY_NOUSE17", textBox93.Text);
            AddUpdateAppSettings("IRKEY_NOUSE18", textBox94.Text);
            AddUpdateAppSettings("IRKEY_NOUSE19", textBox95.Text);
            AddUpdateAppSettings("IRKEY_NOUSE20", textBox96.Text);
            AddUpdateAppSettings("IRKEY_NOUSE21", textBox97.Text);
            AddUpdateAppSettings("IRKEY_NOUSE22", textBox98.Text);
            AddUpdateAppSettings("IRKEY_NOUSE23", textBox99.Text);
            AddUpdateAppSettings("IRKEY_NOUSE24", textBox100.Text);
            AddUpdateAppSettings("IRKEY_VOL100", textBox101.Text);
            AddUpdateAppSettings("IRKEY_COMPONENT2", textBox102.Text);
            AddUpdateAppSettings("IRKEY_HDMI1", textBox103.Text);
            AddUpdateAppSettings("IRKEY_HDMI2", textBox104.Text);
            AddUpdateAppSettings("IRKEY_HDMI3", textBox105.Text);
            AddUpdateAppSettings("IRKEY_HDMI4", textBox106.Text);
            AddUpdateAppSettings("IRKEY_AV1", textBox107.Text);
            AddUpdateAppSettings("IRKEY_AV2", textBox108.Text);
            AddUpdateAppSettings("IRKEY_AV3", textBox109.Text);
            AddUpdateAppSettings("IRKEY_F1", textBox110.Text);
            AddUpdateAppSettings("IRKEY_F2", textBox111.Text);
            AddUpdateAppSettings("IRKEY_F3", textBox112.Text);
            AddUpdateAppSettings("IRKEY_F4", textBox113.Text);
            AddUpdateAppSettings("IRKEY_F5", textBox114.Text);
            AddUpdateAppSettings("IRKEY_WIFI_TEST", textBox115.Text);
            AddUpdateAppSettings("IRKEY_ETHER_TEST", textBox116.Text);
            AddUpdateAppSettings("IRKEY_MAC_SHOW", textBox117.Text);
            AddUpdateAppSettings("IRKEY_MAC_ERASE", textBox118.Text);
            AddUpdateAppSettings("IRKEY_VERSION", textBox119.Text);
            AddUpdateAppSettings("IRKEY_FACTORY_RESTORE", textBox120.Text);
            AddUpdateAppSettings("IRKEY_AUTOSCAN", textBox121.Text);
            AddUpdateAppSettings("IRKEY_PANEL1", textBox122.Text);
            AddUpdateAppSettings("IRKEY_PANEL2", textBox123.Text);
            AddUpdateAppSettings("IRKEY_BURNING", textBox124.Text);
            AddUpdateAppSettings("IRKEY_ADJUST1", textBox125.Text);
            AddUpdateAppSettings("IRKEY_NOUSE_NAME", textBox126.Text);
            AddUpdateAppSettings("IRKEY_NOUSE1_NAME", textBox127.Text);
            AddUpdateAppSettings("IRKEY_NOUSE2_NAME", textBox128.Text);
            AddUpdateAppSettings("IRKEY_NOUSE3_NAME", textBox129.Text);
            AddUpdateAppSettings("IRKEY_NOUSE4_NAME", textBox130.Text);
            AddUpdateAppSettings("IRKEY_NOUSE5_NAME", textBox131.Text);
            AddUpdateAppSettings("IRKEY_NOUSE6_NAME", textBox132.Text);
            AddUpdateAppSettings("IRKEY_NOUSE7_NAME", textBox133.Text);
            AddUpdateAppSettings("IRKEY_NOUSE8_NAME", textBox134.Text);
            AddUpdateAppSettings("IRKEY_NOUSE9_NAME", textBox135.Text);
            AddUpdateAppSettings("IRKEY_NOUSE10_NAME", textBox136.Text);
            AddUpdateAppSettings("IRKEY_NOUSE11_NAME", textBox137.Text);
            AddUpdateAppSettings("IRKEY_NOUSE12_NAME", textBox138.Text);
            AddUpdateAppSettings("IRKEY_NOUSE13_NAME", textBox139.Text);
            AddUpdateAppSettings("IRKEY_NOUSE14_NAME", textBox140.Text);
            AddUpdateAppSettings("IRKEY_NOUSE15_NAME", textBox141.Text);
            AddUpdateAppSettings("IRKEY_NOUSE16_NAME", textBox142.Text);
            AddUpdateAppSettings("IRKEY_NOUSE17_NAME", textBox143.Text);
            AddUpdateAppSettings("IRKEY_NOUSE18_NAME", textBox144.Text);
            AddUpdateAppSettings("IRKEY_NOUSE19_NAME", textBox145.Text);
            AddUpdateAppSettings("IRKEY_NOUSE20_NAME", textBox146.Text);
            AddUpdateAppSettings("IRKEY_NOUSE21_NAME", textBox147.Text);
            AddUpdateAppSettings("IRKEY_NOUSE22_NAME", textBox148.Text);
            AddUpdateAppSettings("IRKEY_NOUSE23_NAME", textBox149.Text);
            AddUpdateAppSettings("IRKEY_NOUSE24_NAME", textBox150.Text);
            AddUpdateAppSettings("IRKEY_NOUSE_LINUX", textBox151.Text);
            AddUpdateAppSettings("IRKEY_NOUSE1_LINUX", textBox152.Text);
            AddUpdateAppSettings("IRKEY_NOUSE2_LINUX", textBox153.Text);
            AddUpdateAppSettings("IRKEY_NOUSE3_LINUX", textBox154.Text);
            AddUpdateAppSettings("IRKEY_NOUSE4_LINUX", textBox155.Text);
            AddUpdateAppSettings("IRKEY_NOUSE5_LINUX", textBox156.Text);
            AddUpdateAppSettings("IRKEY_NOUSE6_LINUX", textBox157.Text);
            AddUpdateAppSettings("IRKEY_NOUSE7_LINUX", textBox158.Text);
            AddUpdateAppSettings("IRKEY_NOUSE8_LINUX", textBox159.Text);
            AddUpdateAppSettings("IRKEY_NOUSE9_LINUX", textBox160.Text);
            AddUpdateAppSettings("IRKEY_NOUSE10_LINUX", textBox161.Text);
            AddUpdateAppSettings("IRKEY_NOUSE11_LINUX", textBox162.Text);
            AddUpdateAppSettings("IRKEY_NOUSE12_LINUX", textBox163.Text);
            AddUpdateAppSettings("IRKEY_NOUSE13_LINUX", textBox164.Text);
            AddUpdateAppSettings("IRKEY_NOUSE14_LINUX", textBox165.Text);
            AddUpdateAppSettings("IRKEY_NOUSE15_LINUX", textBox166.Text);
            AddUpdateAppSettings("IRKEY_NOUSE16_LINUX", textBox167.Text);
            AddUpdateAppSettings("IRKEY_NOUSE17_LINUX", textBox168.Text);
            AddUpdateAppSettings("IRKEY_NOUSE18_LINUX", textBox169.Text);
            AddUpdateAppSettings("IRKEY_NOUSE19_LINUX", textBox170.Text);
            AddUpdateAppSettings("IRKEY_NOUSE20_LINUX", textBox171.Text);
            AddUpdateAppSettings("IRKEY_NOUSE21_LINUX", textBox172.Text);
            AddUpdateAppSettings("IRKEY_NOUSE22_LINUX", textBox173.Text);
            AddUpdateAppSettings("IRKEY_NOUSE23_LINUX", textBox174.Text);
            AddUpdateAppSettings("IRKEY_NOUSE24_LINUX", textBox175.Text);
            MessageBox.Show("保存成功");
        }

        private void REMOTE_CODE_EDITOR_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            //关闭窗口即可保存，暂不使用
            Configuration cfa =ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["HEAD0"].Value = textBox1.Text;
            cfa.AppSettings.Settings["HEAD1"].Value = textBox2.Text;
            cfa.Save();
            */
        }

        private void Load_Click(object sender, EventArgs e)
        {
            IR_NAME_TEXT.Text = ConfigurationManager.AppSettings["IR_NAME"];
            textBox1.Text = ConfigurationManager.AppSettings["IRKEY_HEAD0"];
            textBox2.Text = ConfigurationManager.AppSettings["IRKEY_HEAD1"];
            textBox3.Text = ConfigurationManager.AppSettings["IRKEY_TV_ANTENNA"];
            textBox4.Text = ConfigurationManager.AppSettings["IRKEY_CHANNEL_LIST"];
            textBox5.Text = ConfigurationManager.AppSettings["IRKEY_CHANNEL_FAV_LIST"];
            textBox6.Text = ConfigurationManager.AppSettings["IRKEY_CHANNEL_RETURN"];
            textBox7.Text = ConfigurationManager.AppSettings["IRKEY_CHANNEL_PLUS"];
            textBox8.Text = ConfigurationManager.AppSettings["IRKEY_CHANNEL_MINUS"];
            textBox9.Text = ConfigurationManager.AppSettings["IRKEY_AUDIO"];
            textBox10.Text = ConfigurationManager.AppSettings["IRKEY_VOLUME_PLUS"];
            textBox11.Text = ConfigurationManager.AppSettings["IRKEY_VOLUME_MINUS"];
            textBox12.Text = ConfigurationManager.AppSettings["IRKEY_UP"];
            textBox13.Text = ConfigurationManager.AppSettings["IRKEY_POWER"];
            textBox14.Text = ConfigurationManager.AppSettings["IRKEY_EXIT"];
            textBox15.Text = ConfigurationManager.AppSettings["IRKEY_MENU"];
            textBox16.Text = ConfigurationManager.AppSettings["IRKEY_DOWN"];
            textBox17.Text = ConfigurationManager.AppSettings["IRKEY_LEFT"];
            textBox18.Text = ConfigurationManager.AppSettings["IRKEY_SELECT"];
            textBox19.Text = ConfigurationManager.AppSettings["IRKEY_RIGHT"];
            textBox20.Text = ConfigurationManager.AppSettings["IRKEY_NUM_0"];
            textBox21.Text = ConfigurationManager.AppSettings["IRKEY_NUM_1"];
            textBox22.Text = ConfigurationManager.AppSettings["IRKEY_NUM_2"];
            textBox23.Text = ConfigurationManager.AppSettings["IRKEY_NUM_3"];
            textBox24.Text = ConfigurationManager.AppSettings["IRKEY_NUM_4"];
            textBox25.Text = ConfigurationManager.AppSettings["IRKEY_NUM_5"];
            textBox26.Text = ConfigurationManager.AppSettings["IRKEY_NUM_6"];
            textBox27.Text = ConfigurationManager.AppSettings["IRKEY_NUM_7"];
            textBox28.Text = ConfigurationManager.AppSettings["IRKEY_NUM_8"];
            textBox29.Text = ConfigurationManager.AppSettings["IRKEY_NUM_9"];
            textBox30.Text = ConfigurationManager.AppSettings["IRKEY_MUTE"];
            textBox31.Text = ConfigurationManager.AppSettings["IRKEY_FREEZE"];
            textBox32.Text = ConfigurationManager.AppSettings["IRKEY_CLOCK"];
            textBox33.Text = ConfigurationManager.AppSettings["IRKEY_INFO"];
            textBox34.Text = ConfigurationManager.AppSettings["IRKEY_RED"];
            textBox35.Text = ConfigurationManager.AppSettings["IRKEY_GREEN"];
            textBox36.Text = ConfigurationManager.AppSettings["IRKEY_YELLOW"];
            textBox37.Text = ConfigurationManager.AppSettings["IRKEY_BLUE"];
            textBox38.Text = ConfigurationManager.AppSettings["IRKEY_MTS"];
            textBox39.Text = ConfigurationManager.AppSettings["IRKEY_TTX"];
            textBox40.Text = ConfigurationManager.AppSettings["IRKEY_CC"];
            textBox41.Text = ConfigurationManager.AppSettings["IRKEY_INPUT_SOURCE"];
            textBox42.Text = ConfigurationManager.AppSettings["IRKEY_PICTURE"];
            textBox43.Text = ConfigurationManager.AppSettings["IRKEY_ZOOM"];
            textBox44.Text = ConfigurationManager.AppSettings["IRKEY_AV"];
            textBox45.Text = ConfigurationManager.AppSettings["IRKEY_HDMI"];
            textBox46.Text = ConfigurationManager.AppSettings["IRKEY_SCART"];
            textBox47.Text = ConfigurationManager.AppSettings["IRKEY_PC"];
            textBox48.Text = ConfigurationManager.AppSettings["IRKEY_DTV"];
            textBox49.Text = ConfigurationManager.AppSettings["IRKEY_TV"];
            textBox50.Text = ConfigurationManager.AppSettings["IRKEY_COMPONENT"];
            textBox51.Text = ConfigurationManager.AppSettings["IRKEY_SV"];
            textBox52.Text = ConfigurationManager.AppSettings["IRKEY_USB"];
            textBox53.Text = ConfigurationManager.AppSettings["IRKEY_DASH"];
            textBox54.Text = ConfigurationManager.AppSettings["IRKEY_BACKWARD"];
            textBox55.Text = ConfigurationManager.AppSettings["IRKEY_FORWARD"];
            textBox56.Text = ConfigurationManager.AppSettings["IRKEY_PREVIOUS"];
            textBox57.Text = ConfigurationManager.AppSettings["IRKEY_NEXT"];
            textBox58.Text = ConfigurationManager.AppSettings["IRKEY_PLAY"];
            textBox59.Text = ConfigurationManager.AppSettings["IRKEY_RECORD"];
            textBox60.Text = ConfigurationManager.AppSettings["IRKEY_STOP"];
            textBox61.Text = ConfigurationManager.AppSettings["IRKEY_PAUSE"];
            textBox62.Text = ConfigurationManager.AppSettings["IRKEY_SLEEP"];
            textBox63.Text = ConfigurationManager.AppSettings["IRKEY_EPG"];
            textBox64.Text = ConfigurationManager.AppSettings["IRKEY_HOME"];
            textBox65.Text = ConfigurationManager.AppSettings["IRKEY_FAVORLIST_PLUS"];
            textBox66.Text = ConfigurationManager.AppSettings["IRKEY_FAVORLIST_MINUS"];
            textBox67.Text = ConfigurationManager.AppSettings["IRKEY_MIX"];
            textBox68.Text = ConfigurationManager.AppSettings["IRKEY_INDEX"];
            textBox69.Text = ConfigurationManager.AppSettings["IRKEY_HOLD"];
            textBox70.Text = ConfigurationManager.AppSettings["IRKEY_SUBPAGE"];
            textBox71.Text = ConfigurationManager.AppSettings["IRKEY_SUBCODE"];
            textBox72.Text = ConfigurationManager.AppSettings["IRKEY_SUBTITLE"];
            textBox73.Text = ConfigurationManager.AppSettings["IRKEY_TIME"];
            textBox74.Text = ConfigurationManager.AppSettings["IRKEY_SIZE"];
            textBox75.Text = ConfigurationManager.AppSettings["IRKEY_REVEAL"];
            textBox76.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE"];
            textBox77.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE1"];
            textBox78.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE2"];
            textBox79.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE3"];
            textBox80.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE4"];
            textBox81.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE5"];
            textBox82.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE6"];
            textBox83.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE7"];
            textBox84.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE8"];
            textBox85.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE9"];
            textBox86.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE10"];
            textBox87.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE11"];
            textBox88.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE12"];
            textBox89.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE13"];
            textBox90.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE14"];
            textBox91.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE15"];
            textBox92.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE16"];
            textBox93.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE17"];
            textBox94.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE18"];
            textBox95.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE19"];
            textBox96.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE20"];
            textBox97.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE21"];
            textBox98.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE22"];
            textBox99.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE23"];
            textBox100.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE24"];
            textBox101.Text = ConfigurationManager.AppSettings["IRKEY_VOL100"];
            textBox102.Text = ConfigurationManager.AppSettings["IRKEY_COMPONENT2"];
            textBox103.Text = ConfigurationManager.AppSettings["IRKEY_HDMI1"];
            textBox104.Text = ConfigurationManager.AppSettings["IRKEY_HDMI2"];
            textBox105.Text = ConfigurationManager.AppSettings["IRKEY_HDMI3"];
            textBox106.Text = ConfigurationManager.AppSettings["IRKEY_HDMI4"];
            textBox107.Text = ConfigurationManager.AppSettings["IRKEY_AV1"];
            textBox108.Text = ConfigurationManager.AppSettings["IRKEY_AV2"];
            textBox109.Text = ConfigurationManager.AppSettings["IRKEY_AV3"];
            textBox110.Text = ConfigurationManager.AppSettings["IRKEY_F1"];
            textBox111.Text = ConfigurationManager.AppSettings["IRKEY_F2"];
            textBox112.Text = ConfigurationManager.AppSettings["IRKEY_F3"];
            textBox113.Text = ConfigurationManager.AppSettings["IRKEY_F4"];
            textBox114.Text = ConfigurationManager.AppSettings["IRKEY_F5"];
            textBox115.Text = ConfigurationManager.AppSettings["IRKEY_WIFI_TEST"];
            textBox116.Text = ConfigurationManager.AppSettings["IRKEY_ETHER_TEST"];
            textBox117.Text = ConfigurationManager.AppSettings["IRKEY_MAC_SHOW"];
            textBox118.Text = ConfigurationManager.AppSettings["IRKEY_MAC_ERASE"];
            textBox119.Text = ConfigurationManager.AppSettings["IRKEY_VERSION"];
            textBox120.Text = ConfigurationManager.AppSettings["IRKEY_FACTORY_RESTORE"];
            textBox121.Text = ConfigurationManager.AppSettings["IRKEY_AUTOSCAN"];
            textBox122.Text = ConfigurationManager.AppSettings["IRKEY_PANEL1"];
            textBox123.Text = ConfigurationManager.AppSettings["IRKEY_PANEL2"];
            textBox124.Text = ConfigurationManager.AppSettings["IRKEY_BURNING"];
            textBox125.Text = ConfigurationManager.AppSettings["IRKEY_ADJUST1"];
            textBox126.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE_NAME"];
            textBox127.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE1_NAME"];
            textBox128.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE2_NAME"];
            textBox129.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE3_NAME"];
            textBox130.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE4_NAME"];
            textBox131.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE5_NAME"];
            textBox132.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE6_NAME"];
            textBox133.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE7_NAME"];
            textBox134.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE8_NAME"];
            textBox135.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE9_NAME"];
            textBox136.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE10_NAME"];
            textBox137.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE11_NAME"];
            textBox138.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE12_NAME"];
            textBox139.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE13_NAME"];
            textBox140.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE14_NAME"];
            textBox141.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE15_NAME"];
            textBox142.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE16_NAME"];
            textBox143.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE17_NAME"];
            textBox144.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE18_NAME"];
            textBox145.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE19_NAME"];
            textBox146.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE20_NAME"];
            textBox147.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE21_NAME"];
            textBox148.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE22_NAME"];
            textBox149.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE23_NAME"];
            textBox150.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE24_NAME"];
            textBox151.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE_LINUX"];
            textBox152.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE1_LINUX"];
            textBox153.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE2_LINUX"];
            textBox154.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE3_LINUX"];
            textBox155.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE4_LINUX"];
            textBox156.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE5_LINUX"];
            textBox157.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE6_LINUX"];
            textBox158.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE7_LINUX"];
            textBox159.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE8_LINUX"];
            textBox160.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE9_LINUX"];
            textBox161.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE10_LINUX"];
            textBox162.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE11_LINUX"];
            textBox163.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE12_LINUX"];
            textBox164.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE13_LINUX"];
            textBox165.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE14_LINUX"];
            textBox166.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE15_LINUX"];
            textBox167.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE16_LINUX"];
            textBox168.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE17_LINUX"];
            textBox169.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE18_LINUX"];
            textBox170.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE19_LINUX"];
            textBox171.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE20_LINUX"];
            textBox172.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE21_LINUX"];
            textBox173.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE22_LINUX"];
            textBox174.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE23_LINUX"];
            textBox175.Text = ConfigurationManager.AppSettings["IRKEY_NOUSE24_LINUX"];
        }
        private void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }

}
