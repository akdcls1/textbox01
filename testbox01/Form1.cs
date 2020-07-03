using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testbox01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void input_text_TextChanged(object sender, EventArgs e)
        {   //텍스트 이벤트박스-> 실시간으로 파일을 받고 변환할수 있게 설정가능.
            upper_text.Text = input_text.Text;  //inputtext에 값이 입력되면 uppertext로 값을 넘겨줌.
            reverse_text.Text = input_text.Text;    //inputtext에 값이 입력되면 reversetext로 값을 넘겨줌.

            char[] chararray = this.reverse_text.Text.ToCharArray();    //char배열인 chararray에 reversetext값을 추가
            Array.Reverse(chararray);   //배열을 뒤집음
            string reverseTxt = ""; //reverseTxt string값을 만들어줌.
            for (int i = 0; i <= chararray.Length - 1; i++) //chararray의 length값만큼 반복
            {
                reverseTxt += chararray.GetValue(i);    //
            }
            this.reverse_text.Text = reverseTxt;    //reverseTxt의 값을 reversetext값에 넣어줌.
        }

        private void reverse_text_TextChanged(object sender, EventArgs e)
        {   //만들어진 텍스트 같은걸 더블클릭 할 시에 나타나는 이벤트박스
        }

        private void upper_text_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
