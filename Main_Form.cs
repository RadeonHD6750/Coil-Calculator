using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Electronic_Formula_Library;

namespace Coil_EML
{
    public partial class Main_Form : Form
    {

        private delegate void TextBox_WriteLine_Delegate(string str);
        public Main_Form()
        {
            InitializeComponent();
        }

        public void Exit()
        {
            Application.Exit();
        }

        //텍스트 박스에 문자열 쓰기
        public void TextBox_WriteLine(string str)
        {
            if(System_Message_Box.InvokeRequired)
            {
                TextBox_WriteLine_Delegate textbox_writeline_delegate = new TextBox_WriteLine_Delegate(TextBox_WriteLine_Callback);
                System_Message_Box.Invoke(textbox_writeline_delegate, str);
            }
            else
            {
                TextBox_WriteLine_Callback(str);
            }
        }


        //텍스트 박스에 문자열 콜벡함수
        private void TextBox_WriteLine_Callback(string str)
        {
            System_Message_Box.AppendText(str + "\n");
        }

        private void TextBox_Clear_Click(object sender, EventArgs e)
        {
            System_Message_Box.Clear();
        }

        //창 닫기
        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        //탄자 운동에너지 계산하기 버튼 클릭
        private void Projectile_Ek_Button_Click(object sender, EventArgs e)
        {
            double mass = -1;
            double Velocity = -1;
            double Ek = -1;

            //파싱 예외처리
            try
            {
                mass = double.Parse(Projectile_Mass_TextBox.Text.Trim());
                mass = mass / 1000;
            }
            catch(Exception exception)
            {
                TextBox_WriteLine("질량 입력란에 숫자가 아닙니다. " + exception.Message);
            }

            try
            {
                Velocity = double.Parse(Projectile_Velocity_TextBox.Text.Trim());
            }
            catch (Exception exception)
            {
                TextBox_WriteLine("포구초속 입력란에 숫자가 아닙니다." + exception.Message);
            }

            //음수값 처리
            if(mass > 0 && Velocity > 0)
            {
                Electronic_Formula formula = new Electronic_Formula();

                Ek = formula.Kinetic_Velocity_Energy(mass, Velocity);
            }
           
            //결과출력
            if(Ek >= 0)
            {
                TextBox_WriteLine("질량 " + (mass * 1000) + "gf 포구초속 " + Velocity + "M/s => 운동에너지 " + Math.Round(Ek, 4) + "J");

                Ek_TextBox.Text = Ek.ToString();
            }
            else
            {
                TextBox_WriteLine("음수 감지 여기서는 음의 에너지 취급안함");
            }
        
        }

        //에너지로 탄속 구하기
        private void Energy_to_Velocity_Click(object sender, EventArgs e)
        {
            double mass = -1;
            double inductance = -1;
            double current = -1;
            double Velocity = -1;

            //파싱 예외처리
            try
            {
                mass = double.Parse(Projectile_Mass_TextBox.Text.Trim());
                mass = mass / 1000;
            }
            catch (Exception exception)
            {
                TextBox_WriteLine("질량 입력란에 숫자가 아닙니다." + exception.Message);
            }

            //파싱 예외처리
            try
            {
                inductance = double.Parse(Solenoid_Inductance_TextBox.Text.Trim());
                inductance = inductance / 1000 / 1000; //micro로 변환
            }
            catch (Exception exception)
            {
                TextBox_WriteLine("인덕턴스 입력란에 숫자가 아닙니다." + exception.Message);
            }

            //파싱 예외처리
            try
            {
                current = double.Parse(Solenoid_Current_TextBox.Text.Trim());
            }
            catch (Exception exception)
            {
                TextBox_WriteLine("인가전류 입력란에 숫자가 아닙니다." + exception.Message);
            }

            if(mass > 0 && inductance > 0 && current > 0)
            {
                Electronic_Formula formula = new Electronic_Formula();

                Velocity = formula.Solenoid_Velocity(mass, inductance, current);
            }

            if(Velocity >= 0)
            {
                TextBox_WriteLine("질량 " + (mass * 1000) + "gf 인덕턴스 " + (inductance * 1000 * 1000) + "uH 인가전류 " 
                    + current + "A 탄속 => " + Math.Round(Velocity, 4) + "M/s");

                Projectile_Velocity_TextBox.Text = Velocity.ToString();
            }
            else
            {
                TextBox_WriteLine("음수 감지 여기서는 음의 에너지 취급안함");
            }
        }

       
    }
}
