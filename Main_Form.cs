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
using Winform_Control_Text_Handler_Module;

namespace Coil_EML
{
    public partial class Main_Form : Form
    {
        Winform_Control_Text_Handler controltexthandler;

        List<Control> input_field_list;

        public Main_Form()
        {
            InitializeComponent();

            controltexthandler = new Winform_Control_Text_Handler();
            controltexthandler.Set_Text_Control(System_Message_Box);

            input_field_list = new List<Control>();

            //탄자
            input_field_list.Add(Projectile_Mass_TextBox);
            input_field_list.Add(Projectile_Velocity_TextBox);
            input_field_list.Add(Projectile_Length_TextBox);
            input_field_list.Add(Ek_TextBox);

            //솔레노이드
            input_field_list.Add(Solenoid_Inductance_TextBox);
            input_field_list.Add(Solenoid_Current_TextBox);
            input_field_list.Add(Solenoid_Length_TextBox);
            input_field_list.Add(Solenoid_Voltage_TextBox);

            //타이밍
            input_field_list.Add(Rising_Time_TextBox);
            input_field_list.Add(Accelerator_Stagenumber_TextBox);
        }

        public void Exit()
        {
            Application.Exit();
        }

        public void TextBox_WriteLine(string str)
        {
            controltexthandler.TextControlWrite(str);
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

        //솔레노이드에 저장되는 에너지 구하기
        private void Solenoid_Energy_Button_Click(object sender, EventArgs e)
        {
            double inductance = -1;
            double current = -1;
            double Ew = -1;

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

            if (inductance > 0 && current > 0)
            {
                Electronic_Formula formula = new Electronic_Formula();

                Ew = formula.Solenoid_Energy(inductance, current);
            }

            if(Ew >= 0)
            {
                TextBox_WriteLine("코일 인덕턴스 " + (inductance * 1000 * 1000 )+ "uH 인가전류 " + current + "A 솔레노이드 에너지 => " + Ew + "J");
            }
        }

        //텍스트 박스 클리어
        private void TetxtCotrol_Clear(object sender)
        {
            //각종 예외처리
            if (sender != null)
            {
                TextBox temp = null;

                try
                {
                    temp = (TextBox)sender;
                }
                catch(Exception exception)
                {
                    TextBox_WriteLine(exception.Message);
                }

                temp?.Clear();
            }
        }

        //입력값 전부 지우기
        private void textbox_clear_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < input_field_list.Count; i++)
            {
                TetxtCotrol_Clear(input_field_list[i]);
            }
        }

        //입력값들 개별로 지우기

        //탄자질량 지우기
        private void projectile_mass_label_Click(object sender, EventArgs e)
        {
            TetxtCotrol_Clear(Projectile_Mass_TextBox);
        }

        //탄자탄속 지우기
        private void muzzle_velocity_label_Click(object sender, EventArgs e)
        {
            TetxtCotrol_Clear(Projectile_Velocity_TextBox);
        }

        //탄자길이 지우기
        private void projectile_length_label_Click(object sender, EventArgs e)
        {
            TetxtCotrol_Clear(Projectile_Length_TextBox);
        }

        //탄자 운동에너지 지우기
        private void Ek_label_Click(object sender, EventArgs e)
        {
            TetxtCotrol_Clear(Ek_TextBox);
        }

        //솔레노이드 인덕턴스 지우기
        private void solenoid_inductance_label_Click(object sender, EventArgs e)
        {
            TetxtCotrol_Clear(Solenoid_Inductance_TextBox);
        }

        private void solenoid_current_label_Click(object sender, EventArgs e)
        {
            TetxtCotrol_Clear(Solenoid_Current_TextBox);
        }

        private void solenoid_length_label_Click(object sender, EventArgs e)
        {
            TetxtCotrol_Clear(Solenoid_Length_TextBox);
        }

        private void solenoid_voltage_label_Click(object sender, EventArgs e)
        {
            TetxtCotrol_Clear(Solenoid_Voltage_TextBox);
        }

        private void rising_time_label_Click(object sender, EventArgs e)
        {
            TetxtCotrol_Clear(Rising_Time_TextBox);
        }

        private void acceleator_stage_label_Click(object sender, EventArgs e)
        {
            TetxtCotrol_Clear(Accelerator_Stagenumber_TextBox);
        }

        //여기까지 입력값 개별로 지우기
        ///
    }
}
