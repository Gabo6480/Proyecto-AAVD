using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MAD
{
    enum semana { Lunes,Martes,Miercoles,Jueves,Viernes,Sabado };

    public partial class Dar_Alta_Grupo : Form
    {
        
        private Guid editar;
        public Dar_Alta_Grupo()
        {
         
            InitializeComponent();
        }

        

        private CheckBox ChBx_Array(int X, int Y) {

            CheckBox[] ChBx_Array_0700 = { checkBox30, checkBox60, checkBox90, checkBox120, checkBox150, checkBox180 };
            CheckBox[] ChBx_Array_0730 = { checkBox29, checkBox59, checkBox89, checkBox119, checkBox149, checkBox179 };
            CheckBox[] ChBx_Array_0800 = { checkBox28, checkBox58, checkBox88, checkBox118, checkBox148, checkBox178 };
            CheckBox[] ChBx_Array_0830 = { checkBox27, checkBox57, checkBox87, checkBox117, checkBox147, checkBox177 };
            CheckBox[] ChBx_Array_0900 = { checkBox26, checkBox56, checkBox86, checkBox116, checkBox146, checkBox176 };
            CheckBox[] ChBx_Array_0930 = { checkBox25, checkBox55, checkBox85, checkBox115, checkBox145, checkBox175 };
            CheckBox[] ChBx_Array_1000 = { checkBox24, checkBox54, checkBox84, checkBox114, checkBox144, checkBox174 };
            CheckBox[] ChBx_Array_1030 = { checkBox23, checkBox53, checkBox83, checkBox113, checkBox143, checkBox173 };
            CheckBox[] ChBx_Array_1100 = { checkBox22, checkBox52, checkBox82, checkBox112, checkBox142, checkBox172 };
            CheckBox[] ChBx_Array_1130 = { checkBox21, checkBox51, checkBox81, checkBox111, checkBox141, checkBox171 };
            CheckBox[] ChBx_Array_1200 = { checkBox20, checkBox50, checkBox80, checkBox110, checkBox140, checkBox170 };
            CheckBox[] ChBx_Array_1230 = { checkBox19, checkBox49, checkBox79, checkBox109, checkBox139, checkBox169 };
            CheckBox[] ChBx_Array_1300 = { checkBox18, checkBox48, checkBox78, checkBox108, checkBox138, checkBox168 };
            CheckBox[] ChBx_Array_1330 = { checkBox17, checkBox47, checkBox77, checkBox107, checkBox137, checkBox167 };
            CheckBox[] ChBx_Array_1400 = { checkBox16, checkBox46, checkBox76, checkBox106, checkBox136, checkBox166 };
            CheckBox[] ChBx_Array_1430 = { checkBox15, checkBox45, checkBox75, checkBox105, checkBox135, checkBox165 };
            CheckBox[] ChBx_Array_1500 = { checkBox14, checkBox44, checkBox74, checkBox104, checkBox134, checkBox164 };
            CheckBox[] ChBx_Array_1530 = { checkBox13, checkBox43, checkBox73, checkBox103, checkBox133, checkBox163 };
            CheckBox[] ChBx_Array_1600 = { checkBox12, checkBox42, checkBox72, checkBox102, checkBox132, checkBox162 };
            CheckBox[] ChBx_Array_1630 = { checkBox11, checkBox41, checkBox71, checkBox101, checkBox131, checkBox161 };
            CheckBox[] ChBx_Array_1700 = { checkBox10, checkBox40, checkBox70, checkBox100, checkBox130, checkBox160 };
            CheckBox[] ChBx_Array_1730 = { checkBox9, checkBox39, checkBox69, checkBox99, checkBox129, checkBox159 };
            CheckBox[] ChBx_Array_1800 = { checkBox8, checkBox38, checkBox68, checkBox98, checkBox128, checkBox158 };
            CheckBox[] ChBx_Array_1830 = { checkBox7, checkBox37, checkBox67, checkBox97, checkBox127, checkBox157 };
            CheckBox[] ChBx_Array_1900 = { checkBox6, checkBox36, checkBox66, checkBox96, checkBox126, checkBox156 };
            CheckBox[] ChBx_Array_1930 = { checkBox5, checkBox35, checkBox65, checkBox95, checkBox125, checkBox155 };
            CheckBox[] ChBx_Array_2000 = { checkBox4, checkBox34, checkBox64, checkBox94, checkBox124, checkBox154 };
            CheckBox[] ChBx_Array_2030 = { checkBox3, checkBox33, checkBox63, checkBox93, checkBox123, checkBox153 };
            CheckBox[] ChBx_Array_2100 = { checkBox2, checkBox32, checkBox62, checkBox92, checkBox122, checkBox152 };
            CheckBox[] ChBx_Array_2130 = { checkBox1, checkBox31, checkBox61, checkBox91, checkBox121, checkBox151 };

            switch (Y)
            {
                case 0:
                    return ChBx_Array_0700[X];
                case 1:
                    return ChBx_Array_0730[X];
                case 2:
                    return ChBx_Array_0800[X];
                case 3:
                    return ChBx_Array_0830[X];
                case 4:
                    return ChBx_Array_0900[X];
                case 5:
                    return ChBx_Array_0930[X];
                case 6:
                    return ChBx_Array_1000[X];
                case 7:
                    return ChBx_Array_1030[X];
                case 8:
                    return ChBx_Array_1100[X];
                case 9:
                    return ChBx_Array_1130[X];
                case 10:
                    return ChBx_Array_1200[X];
                case 11:
                    return ChBx_Array_1230[X];
                case 12:
                    return ChBx_Array_1300[X];
                case 13:
                    return ChBx_Array_1330[X];
                case 14:
                    return ChBx_Array_1400[X];
                case 15:
                    return ChBx_Array_1430[X];
                case 16:
                    return ChBx_Array_1500[X];
                case 17:
                    return ChBx_Array_1530[X];
                case 18:
                    return ChBx_Array_1600[X];
                case 19:
                    return ChBx_Array_1630[X];
                case 20:
                    return ChBx_Array_1700[X];
                case 21:
                    return ChBx_Array_1730[X];
                case 22:
                    return ChBx_Array_1800[X];
                case 23:
                    return ChBx_Array_1830[X];
                case 24:
                    return ChBx_Array_1900[X];
                case 25:
                    return ChBx_Array_1930[X];
                case 26:
                    return ChBx_Array_2000[X];
                case 27:
                    return ChBx_Array_2030[X];
                case 28:
                    return ChBx_Array_2100[X];
                case 29:
                    return ChBx_Array_2130[X];
                default:
                    break;
            }
            return null;
        }

        private void updateWindow()
        {
            btn_Registrar.Text = "Registrar";
            editar = Guid.Empty;

            cB_Maestro.DisplayMember = "nombre_completo";
            cB_Maestro.ValueMember = "matricula";
            cB_Maestro.DataSource = Global.DBManager.allTeachersAll();
            cB_Maestro.Enabled = cB_Maestro.Items.Count != 0;
            if (!cB_Maestro.Enabled)
            {
                MessageBox.Show("Error: No existen maestros en la base de datos, contacte al administrador");
            }

            dGV_Consulta.DataSource = Global.DBManager.allGroupAll();
            gB_Consulta.Enabled = dGV_Consulta.RowCount != 0;

            cB_Materia.DataSource = null;
            cB_Materia.Items.Clear();

            tB_Aula.Text = "";

            btn_Registrar.Enabled = false;
            cB_Materia.Enabled = false;
            tB_Aula.Enabled = false;

            for(int I = 0; I < 6; I++)
            {
                for(int J = 0; J < 30; J++)
                {
                    ChBx_Array(I, J).Checked = false;
                    ChBx_Array(I, J).Enabled = true;
                }
            }
            gB_Horario.Enabled = false;
        }

        private void Dar_Alta_Grupo_Load(object sender, EventArgs e)
        {
            updateWindow();
        }

        private void ChBx_ColumnEnable(int C)
        {
            if (C > 5)
            {
                //throw
            }
            else
            {
                bool isEnabled = false;
                for (int I = 0; I < 30; I++)
                {
                    if(ChBx_Array(C, I).Enabled)
                    {
                        isEnabled = true;
                        break;
                    }
                }
                if (isEnabled)
                {
                    for (int I = 0; I < 30; I++)
                    {
                        CheckBox checkBox = ChBx_Array(C, I);
                        checkBox.Checked = false;
                        checkBox.Enabled = false;
                    }
                }
                else
                {
                    for (int I = 0; I < 30; I++)
                    {
                        
                         ChBx_Array(C, I).Enabled = true;
                        
                    }
                }

                int count = ChBx_Count();
                HrsUsd.Text = count.ToString();
                HrsDisp.Text = (int.Parse(HrsRqd.Text) - count).ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ChBx_ColumnEnable(0);
        }   //Lunes

        private void label2_Click(object sender, EventArgs e)
        {
            ChBx_ColumnEnable(1);
        }   //Martes

        private void label3_Click(object sender, EventArgs e)
        {
            ChBx_ColumnEnable(2);
        }   //Miercoles

        private void label4_Click(object sender, EventArgs e)
        {
            ChBx_ColumnEnable(3);
        }   //Jueves

        private void label5_Click(object sender, EventArgs e)
        {
            ChBx_ColumnEnable(4);
        }   //Viernes

        private void label6_Click(object sender, EventArgs e)
        {
            ChBx_ColumnEnable(5);
        }   //Sabado

        private void ChBx_RowCheck(int R)
        {
            if (R > 29)
            {
                //throw
            }
            else
            {
                for (int I = 0; I < 6; I++)
                {
                    CheckBox checkBox = ChBx_Array(I, R);
                    if (checkBox.Checked)
                    {
                        checkBox.Checked = false;
                    }
                    else
                    {
                        if (checkBox.Enabled)
                        {
                            checkBox.Checked = true;
                        }
                    }
                }

                int count = ChBx_Count();
                HrsUsd.Text = count.ToString();
                HrsDisp.Text = (int.Parse(HrsRqd.Text) - count).ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(0);
        }   //7:00

        private void label8_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(1);
        }   //7:30

        private void label9_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(2);
        }   //8:00

        private void label12_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(3);
        }   //8:30

        private void label11_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(4);
        }   //9:00

        private void label10_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(5);
        }   //9:30

        private void label18_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(6);
        }   //10:00

        private void label17_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(7);
        }   //10:30

        private void label16_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(8);
        }   //11:00

        private void label15_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(9);
        }   //11:30

        private void label31_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(10);
        }   //12:00

        private void label14_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(11);
        }   //12:30

        private void label13_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(12);
        }   //13:00

        private void label24_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(13);
        }   //13:30

        private void label23_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(14);
        }   //14:00

        private void label22_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(15);
        }   //14:30

        private void label21_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(16);
        }   //15:00

        private void label20_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(17);
        }   //15:30

        private void label19_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(18);
        }   //16:00

        private void label30_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(19);
        }   //16:30

        private void label29_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(20);
        }   //17:00

        private void label28_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(21);
        }   //17:30

        private void label27_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(22);
        }   //18:00

        private void label26_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(23);
        }   //18:30

        private void label25_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(24);
        }   //19:00

        private void label36_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(25);
        }   //19:30

        private void label35_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(26);
        }   //20:00

        private void label34_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(27);
        }   //20:30

        private void label33_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(28);
        }   //21:00

        private void label32_Click(object sender, EventArgs e)
        {
            ChBx_RowCheck(29);
        }   //21:30

        private int ChBx_Count()
        {
            int Count = 0;

            for(int I = 0; I < 6; I++)
            {
                for(int J = 0; J < 30; J++)
                {
                    if (ChBx_Array(I, J).Checked) {
                        Count++;
                    }
                }
            }

            return Count;
        }   //Cuenta todos los CheckBox palomeados


        private void cB_Materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_Materia.SelectedValue != null)
                HrsRqd.Text = Global.DBManager.oneSubjectAll((int)cB_Materia.SelectedValue).medias_horas_sem.ToString();
        }   //Materia

        private void cB_Maestro_SelectedIndexChanged(object sender, EventArgs e)
        {
            tB_Aula.Enabled = true;
            cB_Materia.DisplayMember = "nombre";
            cB_Materia.ValueMember = "clave";
            if(cB_Maestro.SelectedValue!= null)
                 cB_Materia.DataSource = Global.DBManager.teacherSubjects(int.Parse(cB_Maestro.SelectedValue.ToString()));
            cB_Materia.Enabled = cB_Materia.Items.Count != 0;
            if (!cB_Materia.Enabled)
            {
                MessageBox.Show("Error: No hay materias que imparta este maestro");
            }
        }   //Maestro

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            int count = ChBx_Count();

            if (count == int.Parse(HrsRqd.Text))
            {
                Cassandra.LocalTime time = new Cassandra.LocalTime(0, 0, 0, 0);
                Guid grupo = Global.DBManager.insertGroup(cB_Maestro.Text, cB_Materia.Text, tB_Aula.Text,(int)nUD_Cupo.Value, editar);
                if (editar != Guid.Empty)
                {
                    Global.DBManager.groupHours(grupo, time, false, false, false, false, false, false, true);
                }
                for (int J = 0; J < 30; J++)
                {
                    if (!(ChBx_Array(0, J).Checked || ChBx_Array(1, J).Checked || ChBx_Array(2, J).Checked || ChBx_Array(3, J).Checked || ChBx_Array(4, J).Checked || ChBx_Array(5, J).Checked))
                    {
                        continue;
                    }
                    int hours = J / 2;
                    int minutes = 0;
                    if (J % 2 == 1)
                    {
                        minutes = 30;
                    }
                    hours += 7;
                    time = new Cassandra.LocalTime(hours, minutes, 0, 0);
                    Global.DBManager.groupHours(grupo, time, ChBx_Array(0, J).Checked, ChBx_Array(1, J).Checked, ChBx_Array(2, J).Checked, ChBx_Array(3, J).Checked, ChBx_Array(4, J).Checked, ChBx_Array(5, J).Checked);
                }
                updateWindow();
            }
            else
            {
                MessageBox.Show("Error: Falta asignar horas mandatorias");
                HrsUsd.Text = count.ToString();
                HrsDisp.Text = (int.Parse(HrsRqd.Text) - count).ToString();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btn_Registrar.Text = "Guardar";

            int rou = dGV_Consulta.CurrentCell.RowIndex;
            editar = Guid.Parse(dGV_Consulta.Rows[rou].Cells[id.Name].Value.ToString());

            int maestro = 0;
            var result = Global.DBManager.oneGroupAll(editar);

            cB_Maestro.DisplayMember = "nombre_completo";
            cB_Maestro.ValueMember = "matricula";
            cB_Maestro.DataSource = Global.DBManager.allTeachersAll();
            cB_Maestro.SelectedIndex = cB_Materia.FindStringExact(result.maestro);
            if (cB_Maestro.SelectedIndex < 0)
            {
                cB_Maestro.Text = result.materia;
            }
            else
            {
                maestro = int.Parse(cB_Maestro.SelectedValue.ToString());
            }


            cB_Materia.DisplayMember = "nombre";
            cB_Materia.ValueMember = "clave";
            cB_Materia.DataSource = maestro != 0 ? Global.DBManager.teacherSubjects(maestro) : null;
            cB_Materia.SelectedIndex = maestro != 0 ? cB_Materia.FindStringExact(result.materia) : -1;
            if (cB_Materia.SelectedIndex < 0)
            {
                cB_Materia.Text = result.materia;
            }

            tB_Aula.Text = result.aula;

            foreach (var horario in Global.DBManager.groupHorario(editar))
            {
                        int i = (horario.hora.Hour - 7) * 2;
                        if (horario.hora.Minute == 30)
                        {
                            i++;
                        }

                        if (horario.lunes)
                        { 
                            ChBx_Array(0, i).Enabled = true;
                            ChBx_Array(0, i).Checked = true;
                        }
                        if (horario.martes)
                        {
                            ChBx_Array(1, i).Enabled = true;
                            ChBx_Array(1, i).Checked = true;
                        }
                        if (horario.miercoles)
                        {
                            ChBx_Array(2, i).Enabled = true;
                            ChBx_Array(2, i).Checked = true;
                        }
                        if (horario.jueves)
                        {
                            ChBx_Array(3, i).Enabled = true;
                            ChBx_Array(3, i).Checked = true;
                        }
                        if (horario.viernes)
                        {
                            ChBx_Array(4, i).Enabled = true;
                            ChBx_Array(4, i).Checked = true;
                        }
                        if (horario.sabado)
                        {
                            ChBx_Array(5, i).Enabled = true;
                            ChBx_Array(5, i).Checked = true;
                        }
                    }
                
            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int row = dGV_Consulta.CurrentCell.RowIndex;

            if (MessageBox.Show("Está a punto de eliminar PERMANENTEMENTE el Grupo: \"" + dGV_Consulta.Rows[row].Cells[1].Value.ToString() + "\", ¿Está seguro que desea continuar?",
                                     "Confirmar eliminacion del Grupo",
                                     MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Global.DBManager.deleteGroup(Guid.Parse(dGV_Consulta.Rows[row].Cells[id.Name].Value.ToString()));
                //if (delete.Rows.Count != 0)
                //{
                //    MessageBox.Show(delete.Rows[0].Field<string>("ERROR"));
                //}
            }
            updateWindow();
        }

        private void horaryChBxChanged_CheckedChanged(object sender, EventArgs e)
        {
            int count = ChBx_Count();
            HrsUsd.Text = count.ToString();
            HrsDisp.Text = (int.Parse(HrsRqd.Text) - count).ToString();
        }

        private void tB_Busqueda_TextChanged(object sender, EventArgs e)
        {
            dGV_Consulta.DataSource = Global.DBManager.allGroupAll();
            btn_Editar.Enabled = dGV_Consulta.RowCount != 0;
            btn_Eliminar.Enabled = dGV_Consulta.RowCount != 0;
            Global.searchInDataGridView(dGV_Consulta, tB_Busqueda.Text);
        }

        private void tB_Aula_TextChanged(object sender, EventArgs e)
        {
            gB_Horario.Enabled = true;
            btn_Registrar.Enabled = true;
        }
    }
}
