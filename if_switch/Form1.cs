namespace if_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ifTest();
            switchTest();
        }

        private void switchTest()
        {
            int iRet = 10;

            string strResult = string.Empty;

            switch (iRet)
            {
                case 2:
                case 3:
                    {
                        strResult = "2�� 3";
                    }
                    break;
                case 4:
                    {
                        strResult = "4";
                    }
                    break;
                default:
                    {
                        strResult = "����";
                    }
                    break;
            }
        }

        private void ifTest()
        {
            int ia = 30;
            int ib = 20;

            string strResult = string.Empty;

            if (ia > ib)
            {
                strResult = "ia�� ũ��";
            }
            else if (ia < ib)
            {
                strResult = "ib�� ũ��";
            }
            else
            {
                strResult = "����";
            }

            if (ia > ib) strResult = "ia�� ũ��";
            else strResult = "����";

            strResult = (ia > ib) ? "ia�� ũ��" : "����";

            if (ia > 5 && ib > 5)
            {
                strResult = "�Ѵ� ũ��";
            }

            if (ia > 5 || ib > 5)
            {
                strResult = "��� ���߿� �ϳ��� ũ��";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iNumber1 = (int)nNumber1.Value;
            int iNumber2 = (int)nNumber2.Value;

            if (iNumber1 > iNumber2)
            {
                lblifeResult.Text = string.Format("- Number1�� Number2���� {0} �� Ů�ϴ�.-", iNumber1 - iNumber2);
            }
            else if(iNumber1 < iNumber2)
            {
                lblifeResult.Text = string.Format("- Number2�� Number1���� {0} �� Ů�ϴ�.-", iNumber2 - iNumber1);
            }
            else
            {
                lblifeResult.Text = string.Format("- �� ���ڴ� �����ϴ�. ���� : {0}", iNumber1);
            }
        }

        private void btnswitchResult_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;

            switch (strSelect)
            {
                case "��":
                    lblswitchResult.Text = "- ���� ��¥�� ������ �Դϴ�.-";
                    break;
                case "ȭ":
                    lblswitchResult.Text = "- ���� ��¥�� ȭ���� �Դϴ�.-";
                    break;
                case "��":
                    lblswitchResult.Text = "- ���� ��¥�� ������ �Դϴ�.-";
                    break;
                case "��":
                case "��":
                    lblswitchResult.Text = "- ���� ��¥�� ����� �Ǵ� �ݿ��� �Դϴ�.-";
                    break;
                default:
                    lblswitchResult.Text = "- ���� ��¥�� �ָ� �Դϴ�.(�����, �Ͽ���)";
                    break;
            }
        }
    }
}