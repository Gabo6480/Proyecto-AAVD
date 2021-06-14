using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace Proyecto_MAD
{
    class SqlDBManager
    {
        private SqlConnection sqlCon;
        public SqlDBManager()
        {
            this.sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ProyectoMAD"].ToString());
            this.sqlCon.Open();
            this.sqlCon.Close();
        }
        ~SqlDBManager()
        {
            sqlCon.Dispose();
        }

        public DataTable userValidate(string User, string Password)
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.userValidate", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@user", SqlDbType.NVarChar).Value = User;
                    command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Password;
                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }

        /**
         @option es para seleccionar una de las siguientes:
            0 = subjectTeachers
            1 = subjectCredits
            2 = subjectMandatoryHours
            3 = oneSubjectAll
            4 = allSubjectsForCheck
            5 = allSubjectsAll
            6 = deleteSubject
            7 = subjectBlocks
            8 = blockByAbleSubjects
         */
        public DataTable subjectMultySelect(int option, int subject = 0, string subjectNick = "", string subjectName  = "")
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("subjectMultySelect", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@option", SqlDbType.Int).Value = option;
                    command.Parameters.Add("@subject", SqlDbType.Int).Value = subject;
                    command.Parameters.Add("@subjectNick", SqlDbType.NVarChar).Value = subjectNick;
                    command.Parameters.Add("@subjectName", SqlDbType.NVarChar).Value = subjectName;

                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }

        /**
         @option es para seleccionar una de las siguientes:
            0 = allCareersAll
            1 = careersWithoutCoordinator
            2 = oneCareerAll
            3 = deleteCareer
            4 = careerSubjects
         */
        public DataTable careerMultySelect(int option, int career = 0, string careerNick = "", string careerName = "")
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("careerMultySelect", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@option", SqlDbType.Int).Value = option;
                    command.Parameters.Add("@career", SqlDbType.Int).Value = career;
                    command.Parameters.Add("@careerNick", SqlDbType.NVarChar).Value = careerNick;
                    command.Parameters.Add("@careerName", SqlDbType.NVarChar).Value = careerName;

                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }

        public DataTable studentMultySelect(int option, int student = 0)
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("studentMultySelect", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@option", SqlDbType.Int).Value = option;
                    command.Parameters.Add("@student", SqlDbType.Int).Value = student;

                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }

        public DataTable coordinatorMultySelect(int option, string coordinator = "")
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("coordinatorMultySelect", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@option", SqlDbType.Int).Value = option;
                    command.Parameters.Add("@coordinator", SqlDbType.NVarChar).Value = coordinator;

                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }

        public DataTable teacherMultySelect(int option, int teacher = 0)
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("teacherMultySelect", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@option", SqlDbType.Int).Value = option;
                    command.Parameters.Add("@teacher", SqlDbType.Int).Value = teacher;

                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }

        public DataTable classroomMultySelect(int option, int classroom = 0)
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("classroomMultySelect", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@option", SqlDbType.Int).Value = option;
                    command.Parameters.Add("@classroom", SqlDbType.Int).Value = classroom;

                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }

        public DataTable groupMultySelect(int option, int group = -1)
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("groupMultySelect", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@option", SqlDbType.Int).Value = option;
                    command.Parameters.Add("@group", SqlDbType.Int).Value = group;

                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }

        public DataTable semesterMultySelect(int option, int semester = -1)
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("semesterMultySelect", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@option", SqlDbType.Int).Value = option;
                    command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;

                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }

        public DataTable allCountryNames()
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("allCountryNames", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }


        public int insertSubject(string name, string nick = "", string description = "", short credits = 1, short halveHrs = 1, byte level = 1, int code = 0)
        {
            int result;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.insertSubject", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@nick", SqlDbType.NVarChar).Value = nick;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;
                command.Parameters.Add("@credits", SqlDbType.SmallInt).Value = credits;
                command.Parameters.Add("@halveHrs", SqlDbType.SmallInt).Value = halveHrs;
                command.Parameters.Add("@level", SqlDbType.TinyInt).Value = level;
                command.Parameters.Add("@code", SqlDbType.Int).Value = code;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value;
            }
            sqlCon.Close();
            return result;
        }

        public int insertCareer(string name, string nick = "", string description = "", int code = 0)
        {
            int result;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.insertCareer", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@nick", SqlDbType.NVarChar).Value = nick;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;
                command.Parameters.Add("@code", SqlDbType.Int).Value = code;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value;
            }
            sqlCon.Close();
            return result;
        }

        public int insertStudent(string name, string mdlnme, string lstnme, DateTime birthdate, string career, string country, bool gender = true, int ID = 0)
        {
            int result;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.insertStudent", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@mdlnme", SqlDbType.NVarChar).Value = mdlnme;
                command.Parameters.Add("@lstnme", SqlDbType.NVarChar).Value = lstnme;
                command.Parameters.Add("@birthdate", SqlDbType.Date).Value = birthdate;
                command.Parameters.Add("@career", SqlDbType.NVarChar).Value = career;
                command.Parameters.Add("@country", SqlDbType.NVarChar).Value = country;
                command.Parameters.Add("@gender", SqlDbType.Bit).Value = gender;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value;
            }
            sqlCon.Close();
            return result;
        }

        public int insertCoordinator(string name, string sndnme, string lstnme, DateTime birthdate, string career, string number, string user, string password, string degree = "", bool gender = true, bool update = false)
        {
            int result;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.insertCoordinator", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@sndnme", SqlDbType.NVarChar).Value = sndnme;
                command.Parameters.Add("@lstnme", SqlDbType.NVarChar).Value = lstnme;
                command.Parameters.Add("@birthdate", SqlDbType.Date).Value = birthdate;
                command.Parameters.Add("@career", SqlDbType.NVarChar).Value = career;
                command.Parameters.Add("@number", SqlDbType.NVarChar).Value = number;
                command.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                command.Parameters.Add("@degree", SqlDbType.NVarChar).Value = degree;
                command.Parameters.Add("@gender", SqlDbType.Bit).Value = gender;
                command.Parameters.Add("@update", SqlDbType.Bit).Value = update;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value;
            }
            sqlCon.Close();
            return result;
        }

        public bool subjectBlockSubject(int subject, int block, bool remove)
        {
            bool result;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.subjectBlockSubject", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@subject", SqlDbType.Int).Value = subject;
                command.Parameters.Add("@block", SqlDbType.Int).Value = block;
                command.Parameters.Add("@remove", SqlDbType.Bit).Value = remove;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value == 1;
            }
            sqlCon.Close();
            return result;
        }

        public bool careerSubjects(int career, int subject, bool remove)
        {
            bool result;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.careerSubjects", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@subject", SqlDbType.Int).Value = subject;
                command.Parameters.Add("@career", SqlDbType.Int).Value = career;
                command.Parameters.Add("@remove", SqlDbType.Bit).Value = remove;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value == 1;
            }
            sqlCon.Close();
            return result;
        }

        public int insertTeacher(string name, string sndnme, string lstnme, DateTime birthdate, string number, string degree = "", bool gender = true, int id = 0)
        {
            int result = 0;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.insertTeacher", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@sndnme", SqlDbType.NVarChar).Value = sndnme;
                command.Parameters.Add("@lstnme", SqlDbType.NVarChar).Value = lstnme;
                command.Parameters.Add("@birthdate", SqlDbType.Date).Value = birthdate;
                command.Parameters.Add("@number", SqlDbType.NVarChar).Value = number;
                command.Parameters.Add("@degree", SqlDbType.NVarChar).Value = degree;
                command.Parameters.Add("@gender", SqlDbType.Bit).Value = gender;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value;
            }
            sqlCon.Close();
            return result;
        }

        public int teacherSubject(int teacher, int subject, bool remove = false)
        {
            int result = 0;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.teacherSubject", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@teacher", SqlDbType.Int).Value = teacher;
                command.Parameters.Add("@subject", SqlDbType.Int).Value = subject;
                command.Parameters.Add("@remove", SqlDbType.Bit).Value = remove;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value;
            }
            sqlCon.Close();
            return result;
        }

        public int insertGroup(int teacher, int subject, int classroom, int group = -1)
        {
            int result;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.insertGroup", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@teacher", SqlDbType.Int).Value = teacher;
                command.Parameters.Add("@subject", SqlDbType.Int).Value = subject;
                command.Parameters.Add("@classroom", SqlDbType.Int).Value = classroom;
                command.Parameters.Add("@group", SqlDbType.Int).Value = group;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value;
            }
            sqlCon.Close();
            return result;
        }

        public int groupHours(int group, TimeSpan hour, bool monday, bool tuesday, bool wednesday, bool thursday, bool friday, bool saturday, bool update = false)
        {
            int result;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.groupHours", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@group", SqlDbType.Int).Value = group;
                command.Parameters.Add("@hour", SqlDbType.Time).Value = hour;
                command.Parameters.Add("@monday", SqlDbType.Bit).Value = monday;
                command.Parameters.Add("@tuesday", SqlDbType.Bit).Value = tuesday;
                command.Parameters.Add("@wednesday", SqlDbType.Bit).Value = wednesday;
                command.Parameters.Add("@thursday", SqlDbType.Bit).Value = thursday;
                command.Parameters.Add("@friday", SqlDbType.Bit).Value = friday;
                command.Parameters.Add("@saturday", SqlDbType.Bit).Value = saturday;
                command.Parameters.Add("@update", SqlDbType.Bit).Value = update;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value;
            }
            sqlCon.Close();
            return result;
        }

        public bool insertSemester(short min, short max, DateTime start, DateTime end ,int semester = -1)
        {
            bool result;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.insertSemester", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@min", SqlDbType.SmallInt).Value = min;
                command.Parameters.Add("@max", SqlDbType.SmallInt).Value = max;
                command.Parameters.Add("@start", SqlDbType.Date).Value = start;
                command.Parameters.Add("@end", SqlDbType.Date).Value = end;
                command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value == 1;
            }
            sqlCon.Close();
            return result;
        }

        public int enrollStudentToGroup(int group, int student, bool remove = false)
        {
            int result = 0;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.enrollStudentToGroup", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@group", SqlDbType.Int).Value = group;
                command.Parameters.Add("@student", SqlDbType.Int).Value = student;
                command.Parameters.Add("@remove", SqlDbType.Bit).Value = remove;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value;
            }
            sqlCon.Close();
            return result;
        }

        public int updateCalification(int group, int student, float calification)
        {
            if(calification > 100.0f)
            {
                calification = 100.0f;
            }
            if(calification < 0.0f)
            {
                calification = 0.0f;
            }
            int result = 0;
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("dbo.updateCalification", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@group", SqlDbType.Int).Value = group;
                command.Parameters.Add("@student", SqlDbType.Int).Value = student;
                command.Parameters.Add("@calification", SqlDbType.Float).Value = calification;

                SqlParameter returnParameter = command.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();

                result = (int)returnParameter.Value;
            }
            sqlCon.Close();
            return result;
        }

        public DataTable careerAverages(bool semestral, int career = 0)
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("careerAverages", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@semestral", SqlDbType.Bit).Value = semestral;
                    command.Parameters.Add("@carrer", SqlDbType.Int).Value = career;

                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }

        public DataTable subjectAverages(int option, int subject = -1)
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("subjectAverages", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@option", SqlDbType.Int).Value = option;
                    command.Parameters.Add("@subject", SqlDbType.Int).Value = subject;

                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }

        public DataTable semesterAverages(int option, int semester = -1)
        {
            DataTable result = new DataTable();
            sqlCon.Open();
            using (SqlCommand command = new SqlCommand("semesterAverages", sqlCon))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@option", SqlDbType.Int).Value = option;
                    command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;

                    dataAdapter.Fill(result);
                }
            }
            sqlCon.Close();
            return result;
        }
    }
}
