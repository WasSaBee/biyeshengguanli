using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graduate_management.GMclass
{
    class Nations
    {
        public bool isNations(string nation)
        {
            bool isNation = true;
            switch (nation)
            {
                case "汉族":
                case "蒙古族":
                case "回族":
                case "藏族":
                case "维吾尔族":
                case "苗族":
                case "彝族":
                case "壮族":
                case "布依族":
                case "朝鲜族":
                case "满族":
                case "侗族":
                case "瑶族":
                case "白族":
                case "土家族":
                case "哈尼族":
                case "哈萨克族":
                case "傣族":
                case "黎族":
                case "傈僳族":
                case "佤族":
                case "高山族":
                case "畲族":
                case "拉祜族":
                case "水族":
                case "东乡族":
                case "纳西族":
                case "景颇族":
                case "柯尔克孜族":
                case "土族":
                case "达斡尔族":
                case "仫佬族":
                case "羌族":
                case "布朗族":
                case "撒拉族":
                case "毛南族":
                case "仡佬族":
                case "锡伯族":
                case "阿昌族":
                case "普米族":
                case "塔吉克族":
                case "怒族":
                case "乌孜别克族":
                case "俄罗斯族":
                case "鄂温克族":
                case "崩龙族":
                case "保安族":
                case "裕固族":
                case "京族":
                case "塔塔尔族":
                case "独龙族":
                case "鄂伦春族":
                case "赫哲族":
                case "门巴族":
                case "珞巴族":
                case "基诺族":
                case "其他":
                    break;
                default:
                    isNation = false; break;
            }
            return isNation;
        }
        public bool isPoliticians(string str) {
            switch (str) {
                case "中共党员":
                case "中共预备党员":
                case "共青团员":
                case "民革党员":
                case "民盟盟员":
                case "民建会员":
                case "民进会员":
                case "致公党党员":
                case "农工党党员":
                case "九三学社社员":
                case "台盟盟员":
                case "无党派人士":
                case "群众":return true;
                default:return false;
            }
        }
        public bool isIDCard(string str) {
            int[] power = {7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2 };
            int[] yushu = { 1,0,10,9,8,7,6,5,4,3,2};
            int last = 0,num=0;
                for (int i = 0; i <= str.Length-2; i++) {
                    int.TryParse(str[i].ToString(),out num);
                    last += num * power[i];
                }
                last = last%11;
            if (str.Substring(str.Length-1, 1) == "X")
             {
                 if (yushu[last]==10) return true;
                 else return false;
             }
             else {
                 int.TryParse(str.Substring(str.Length-1, 1), out num);
                 if (yushu[last] == num) return true;
                 else return false;
             }    
        }
        public bool isEmail(string str) {
            Regex re = new Regex("\\w+@(\\w+)+.com");
            return re.IsMatch(str);
        }
    }
}
