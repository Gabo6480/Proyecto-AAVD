using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;

namespace Proyecto_MAD
{
    struct alumno
    {
        public int matricula { get; set; }
        public string nombre { get; set; }
        public string apellido_pat { get; set; }
        public string apellido_mat { get; set; }
        public bool genero { get; set; }
        public LocalDate fecha_naci { get; set; }
        public bool activo { get; set; }

        public string carrera { get; set; }
        public string pais { get; set; }

        public alumno(int matricula, string nombre,string apellido_pat,string apellido_mat,bool genero,LocalDate fecha_naci,bool activo,string carrera,string pais)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.apellido_pat = apellido_pat;
            this.apellido_mat = apellido_mat;
            this.genero = genero;
            this.fecha_naci = fecha_naci;
            this.activo = activo;

            this.carrera = carrera;
            this.pais = pais;
        }
    }
    struct login
    {
        public string clave_usuario { get; set; }
        public string titulo { get; set; }

        public login(string user, string title)
        {
            clave_usuario = user;
            titulo = title;
        }
    }
    struct carrera
    {
        public Guid id { get; set; }
        public int clave { get; set; }
        public string nombre { get; set; }
        public string alias { get; set; }
        public string descripcion { get; set; }

        public carrera(Guid uuid, int code,string name, string nick, string desc)
        {
            id = uuid;
            clave = code;
            nombre = name;
            alias = nick;
            descripcion = desc;
        }
    }
    struct setSelect<T>
    {
        public IEnumerable<T> set { get; set; }
        public setSelect(IEnumerable<T> Type)
        {
            set = Type;
        }
    }
    struct rMateria
    {
        public int clave { get; set; }
        public string nombre { get; set; }
        public string alias { get; set; }

        public rMateria(int code, string name, string nick)
        {
            clave = code;
            nombre = name;
            alias = nick;
        }
    }

    struct materia
    {
        Guid id { get; set; }
        public int clave { get; set; }
        public string nombre { get; set; }
        public string alias { get; set; }
        public string descripcion { get; set; }
        public short creditos { get; set; }
        public short medias_horas_sem { get; set; }
        public byte nivel { get; set; }

        public materia(Guid uuid,int code,string name,string nick, string desc, short credits, short hours, byte level)
        {
            id = uuid;
            clave = code;
            nombre = name;
            alias = nick;
            descripcion = desc;
            creditos = credits;
            medias_horas_sem = hours;
            nivel = level;
        }
}

    struct coordinador
    {
        public string clave_usuario { get; set; }
        public string contrasena { get; set; }
        public string carrera { get; set; }
        public string num_nomina { get; set; }
        public string nombre { get; set; }
        public string apellido_pat { get; set; }
        public string apellido_mat { get; set; }
        public string titulo { get; set; }
        public bool genero { get; set; }
        public LocalDate fecha_naci { get; set; }

        

        public coordinador(string clave_usuario, string contrasena, string carrera, string num_nomina,  string nombre, string apellido_pat, string apellido_mat, string titulo, bool genero, LocalDate fecha_naci)
        {
            this.clave_usuario = clave_usuario;
            this.contrasena = contrasena;
            this.carrera = carrera;
            this.num_nomina = num_nomina;
            this.nombre = nombre;
            this.apellido_pat = apellido_pat;
            this.apellido_mat = apellido_mat;
            this.titulo = titulo;
            this.genero = genero;
            this.fecha_naci = fecha_naci;
        }
    }

    struct maestro
    {
        public int matricula { get; set; }
        public string num_nomina { get; set; }
        public string nombre { get; set; }
        public string nombre_completo { get; set; }
        public string apellido_pat { get; set; }
        public string apellido_mat { get; set; }
        public string titulo { get; set; }
        public bool genero { get; set; }
        public LocalDate fecha_naci { get; set; }



        public maestro(int matricula, string num_nomina,string nombre_completo, string nombre, string apellido_pat, string apellido_mat, string titulo, bool genero, LocalDate fecha_naci)
        {
            this.matricula = matricula;
            this.num_nomina = num_nomina;
            this.nombre = nombre;
            this.nombre_completo = nombre_completo;
            this.apellido_pat = apellido_pat;
            this.apellido_mat = apellido_mat;
            this.titulo = titulo;
            this.genero = genero;
            this.fecha_naci = fecha_naci;
        }
    }

    struct kardex
    {
        public string nombre { get; set; }
        public string materia { get; set; }
        public int matricula { get; set; }
        public float calificacion { get; set; }
        public string semestre { get; set; }

        public kardex(string nombre,int matricula, string materia, float calificacion,string semestre)
        {
            this.nombre = nombre;
            this.materia = materia;
            this.matricula = matricula;
            this.calificacion = calificacion;
            this.semestre = semestre;
        }
    }

    struct semestre
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public LocalDate fecha_inicio    { get; set; }
	    public LocalDate fecha_fin { get; set; }
        public short creditos_min    { get; set; }
        public short creditos_max { get; set; }
        public string estado { get; set; }

        public semestre(Guid id, string nombre, LocalDate fecha_inicio,LocalDate fecha_fin,short creditos_min,short creditos_max,string estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha_fin = fecha_fin;
            this.fecha_inicio = fecha_inicio;
            this.creditos_min = creditos_min;
            this.creditos_max = creditos_max;
            this.estado = estado;
        }
    }

    struct grupo
    {
        public Guid id { get; set; }
        public string materia { get; set; }
        public string maestro { get; set; }
        public string aula { get; set; }
        public string semestre { get; set; }
        public int cupo { get; set; }

        public grupo(Guid id, int cupo, string materia, string maestro, string aula, string semestre)
        {
            this.id = id;
            this.materia = materia;
            this.maestro = maestro;
            this.aula = aula;
            this.semestre = semestre;
            this.cupo = cupo;
        }

    }
    struct horario
    {
        public LocalTime hora { get; set; }
        public bool lunes { get; set; }
        public bool martes { get; set; }
        public bool miercoles { get; set; }
        public bool jueves { get; set; }
        public bool viernes { get; set; }
        public bool sabado { get; set; }

        public horario(LocalTime hora, bool lunes,bool martes,bool miercoles,bool jueves,bool viernes,bool sabado)
        {
            this.hora = hora;
            this.lunes = lunes;
            this.martes = martes;
            this.miercoles = miercoles;
            this.jueves = jueves;
            this.viernes = viernes;
            this.sabado = sabado;
        }
    }
    struct grupo_alumno
    {
        public int matricula { get; set; }
        public string nombre { get; set; }
        public float calificacion { get; set; }

        public grupo_alumno(int matr, string name, float califi)
        {
            matricula = matr;
            nombre = name;
            calificacion = califi;
        }
    }

    class CqlDBManager
    {
        private ISession session;
        private Cluster cluster;
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        public CqlDBManager()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();
        }

        private void Connect()
        {
            cluster = Cluster.Builder().AddContactPoint(_dbServer).Build();
            session = cluster.Connect(_dbKeySpace);
        }

        private void Disconnect()
        {
            cluster.Dispose();
            session.Dispose();
        }

        //CQL
        public login userValidate(string user, string password)
        {
            Connect();
            login logins;
            try
            {
                IMapper mapper = new Mapper(session);
                logins = mapper.Single<login>("SELECT clave_usuario,titulo FROM coordinador WHERE clave_usuario=? AND contrasena=?", user, password);
            }
            catch (Exception e)
            {
                logins = new login("","");
            }
            finally
            {
                Disconnect();
            }
            return logins;
        }

        //carrera
        public bool insertCareer(int clave, string nombre, string alias, string descripcion = "No especificado")
        {
            bool result;
            try
            {
                Connect();

                var insert = session.Prepare("INSERT INTO carrera (id, clave, nombre, alias, descripcion) VALUES (uuid(),?,?,?,?);");

                //...bind different parameters every time you need to execute
                var statement = insert.Bind(clave, nombre, alias, descripcion);

                //Execute the bound statement with the provided parameters
                session.Execute(statement);

                Disconnect();
            }
            catch (Exception e)
            {
                result = false;
            }
            finally
            {
                result = true;
            }
            return result;
        }
        public bool updateCareer(Guid uuid, int clave, string nombre, string alias, string descripcion = "No especificado")
        {
            bool result;
            try
            {
                Connect();

                var update = session.Prepare("UPDATE carrera SET clave = ?, nombre = ?, alias = ?, descripcion = ? WHERE id = ?;");

                //...bind different parameters every time you need to execute
                var statement = update.Bind(clave, nombre, alias, descripcion, uuid);

                //Execute the bound statement with the provided parameters
                session.Execute(statement);

                Disconnect();
            }
            catch (Exception e)
            {
                result = false;
            }
            finally
            {
                result = true;
            }
            return result;
        }
        public carrera oneCareerAll(Guid uuid)
        {
            Connect();
            IMapper mapper = new Mapper(session);
            var carrera = mapper.Single<carrera>("SELECT id,clave,nombre,alias,descripcion FROM carrera WHERE id=?", uuid);
            Disconnect();
            return carrera;
        }
        public IList<carrera> allCareersAll()
        {
            Connect();
            IMapper mapper = new Mapper(session);
            IEnumerable<carrera> carreras = mapper.Fetch<carrera>("SELECT id,clave,nombre,alias,descripcion FROM carrera");
            Disconnect();

            return carreras.ToList();

        }
        public void deleteCareer(Guid uuid)
        {
            Connect();
            var delete = session.Prepare("DELETE FROM carrera WHERE id = ?");

            //...bind different parameters every time you need to execute
            var statement = delete.Bind(uuid);

            //Execute the bound statement with the provided parameters
            session.Execute(statement);
            Disconnect();
        }
        public IEnumerable<rMateria> careerSubjects(Guid uuid)
        {
            Connect();
            session.UserDefinedTypes.Define(UdtMap.For<rMateria>());
            var insert = session.Prepare("SELECT materias FROM carrera WHERE id = ?");
            //...bind different parameters every time you need to execute
            var statement = insert.Bind(uuid);
            //Execute the bound statement with the provided parameters
            IEnumerable<rMateria> materias = session.Execute(statement).First().GetValue<rMateria[]>("materias"); 

            Disconnect();

            return materias;

        }

        //materias
        public IList<materia> allSubjectsAll()
        {
            Connect();
            IMapper mapper = new Mapper(session);
            IEnumerable<materia> carreras = mapper.Fetch<materia>("SELECT id,clave,nombre,alias,descripcion,creditos,medias_horas_sem,nivel FROM materia");
            Disconnect();

            return carreras.ToList();

        }
        public materia oneSubjectAll(Guid uuid)
        {
            Connect();
            IMapper mapper = new Mapper(session);
            var carrera = mapper.Single<materia>("SELECT id,clave,nombre,alias,descripcion,creditos,medias_horas_sem,nivel FROM materia WHERE id=?", uuid);
            Disconnect();
            return carrera;
        }
        public materia oneSubjectAll(int clave)
        {
            Connect();
            IMapper mapper = new Mapper(session);
            var carrera = mapper.Single<materia>("SELECT id,clave,nombre,alias,descripcion,creditos,medias_horas_sem,nivel FROM materia WHERE clave=? ALLOW FILTERING", clave);
            Disconnect();
            return carrera;
        }
        public void deleteSubject(Guid uuid)
        {
            Connect();
            var delete = session.Prepare("DELETE FROM materia WHERE id = ?");

            //...bind different parameters every time you need to execute
            var statement = delete.Bind(uuid);

            //Execute the bound statement with the provided parameters
            session.Execute(statement);
            Disconnect();
        }
        public bool insertSubject(string name, string nick, string description = "No especificado", short credits = 1, short halveHrs = 1, sbyte level = 1, int code = 0)
        {
            bool exception = false;
            bool result;
            try
            {
                Connect();

                var insert = session.Prepare("INSERT INTO materia (id, clave, nombre, alias, descripcion, creditos, medias_horas_sem, nivel)" +
                             " VALUES (uuid(),?,?,?,?,?,?,?);");

                //...bind different parameters every time you need to execute
                var statement = insert.Bind(code, name, nick, description,credits,halveHrs,level);

                //Execute the bound statement with the provided parameters
                session.Execute(statement);

                Disconnect();
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(e.ToString());
                exception = true;
            }
            finally
            {
                result = !exception;
            }
            return result;
        }
        public bool updateSubject(Guid uuid, string name, string nick, string description = "No especificado", short credits = 1, short halveHrs = 1, sbyte level = 1, int code = 0)
        {
            bool exception = false;
            bool result;
            try
            {
                Connect();

                var update = session.Prepare("UPDATE materia SET clave = ?, nombre = ?, alias = ?, descripcion = ?, creditos = ?, medias_horas_sem = ?, nivel = ?" +
                                            " WHERE id = ?;");

                //...bind different parameters every time you need to execute
                var statement = update.Bind(code, name, nick, description, credits, halveHrs, level,uuid);

                //Execute the bound statement with the provided parameters
                session.Execute(statement);

                Disconnect();
            }
            catch (Exception e)
            {
                exception = true;
            }
            finally
            {
                result = !exception;
            }
            return result;
        }


        public bool careerSubjects(Guid career, int sCode, string sName, string sNick, bool remove)
        {
            bool result = false;
            Connect();
            PreparedStatement preparedStatement;
            if (remove)
            {
                preparedStatement = session.Prepare("UPDATE carrera SET materias = materias - {{clave : " + sCode.ToString() + ",nombre : '" + sName + "',alias : '" + sNick + "'}} WHERE id = ?; ");
            }
            else
            {
                preparedStatement = session.Prepare("UPDATE carrera SET materias = materias + {{clave : "+ sCode.ToString() +",nombre : '"+ sName +"',alias : '" + sNick +"'}} WHERE id = ?; ");
            }
            //...bind different parameters every time you need to execute
            BoundStatement boundStatement = preparedStatement.Bind(career);

            //Execute the bound statement with the provided parameters
            session.Execute(boundStatement);
            Disconnect();
            return result;
        }

        //coordinadores
        public IList<coordinador> allCoordsAll()
        {
            Connect();
            IMapper mapper = new Mapper(session);
            IEnumerable<coordinador> coordinadores = mapper.Fetch<coordinador>("SELECT clave_usuario,contrasena,carrera,num_nomina,nombre,apellido_pat,apellido_mat,titulo,genero,fecha_naci FROM coordinador");
            Disconnect();

            var list = coordinadores.ToList();

            foreach (var row in list)
            {
                if(row.titulo == "Administrador/a")
                {
                    list.Remove(row);
                    break;
                }
            }
            

            return list;

        }
        public coordinador oneCoordAll(string user)
        {
            Connect();
            IMapper mapper = new Mapper(session);
            var coordinador = mapper.Single<coordinador>("SELECT clave_usuario,contrasena,carrera,num_nomina,nombre,apellido_pat,apellido_mat,titulo,genero,fecha_naci FROM coordinador WHERE clave_usuario=?", user);
            Disconnect();
            return coordinador;
        }
        public void deleteCoord(string user)
        {
            Connect();
            var delete = session.Prepare("DELETE FROM coordinador WHERE clave_usuario = ?");

            //...bind different parameters every time you need to execute
            var statement = delete.Bind(user);

            //Execute the bound statement with the provided parameters
            session.Execute(statement);
            Disconnect();
        }
        public bool insertCoordinator(string name, string sndnme, string lstnme, DateTime birthdate, string career, string number, string user, string password, string degree = "", bool gender = true, bool update = false)
        {
            bool exception = false;
            bool result;
            try
            {
                Connect();
                PreparedStatement preparedStatement;
                if (update)
                {
                    preparedStatement = session.Prepare("UPDATE coordinador SET nombre = ?,apellido_pat = ?,apellido_mat = ?,fecha_naci = ?,carrera = ?,num_nomina = ?,titulo = ?,genero = ?" +
                                 " WHERE clave_usuario = ? AND contrasena = ?;");
                }
                else
                {
                    preparedStatement = session.Prepare("INSERT INTO coordinador (nombre,apellido_pat,apellido_mat,fecha_naci,carrera,num_nomina,titulo,genero,clave_usuario,contrasena)" +
                                " VALUES (?,?,?,?,?,?,?,?,?,?);");
                }

                //...bind different parameters every time you need to execute
                var boundStatement = preparedStatement.Bind( name, sndnme, lstnme, new LocalDate(birthdate.Year,birthdate.Month,birthdate.Day), career, number, degree, gender, user, password);

                //Execute the bound statement with the provided parameters
                session.Execute(boundStatement);

                Disconnect();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                exception = true;
            }
            finally
            {
                result = !exception;
            }
            return result;
        }

        //maestros
        public IList<maestro> allTeachersAll()
        {
            Connect();
            IMapper mapper = new Mapper(session);
            IEnumerable<maestro> maestros = mapper.Fetch<maestro>("SELECT matricula,num_nomina,nombre_completo,nombre,apellido_pat,apellido_mat,titulo,genero,fecha_naci FROM maestro");
            Disconnect();

            return maestros.ToList();
        }
        public maestro oneTeacherAll(int user)
        {
            Connect();
            IMapper mapper = new Mapper(session);
            var maestro = mapper.Single<maestro>("SELECT matricula,num_nomina,nombre_completo,nombre,apellido_pat,apellido_mat,titulo,genero,fecha_naci FROM maestro WHERE matricula=?", user);
            Disconnect();
            return maestro;
        }
        public IEnumerable<rMateria> teacherSubjects(int uuid)
        {
            Connect();
            session.UserDefinedTypes.Define(UdtMap.For<rMateria>());
            var insert = session.Prepare("SELECT materias FROM maestro WHERE matricula = ?");
            //...bind different parameters every time you need to execute
            var statement = insert.Bind(uuid);
            //Execute the bound statement with the provided parameters
            IEnumerable<rMateria> materias = session.Execute(statement).First().GetValue<rMateria[]>("materias");

            Disconnect();

            return materias;

        }
        public void deleteTeacher(int user)
        {
            Connect();
            var delete = session.Prepare("DELETE FROM maestro WHERE matricula = ?");

            //...bind different parameters every time you need to execute
            var statement = delete.Bind(user);

            //Execute the bound statement with the provided parameters
            session.Execute(statement);
            Disconnect();
        }
        public bool insertTeacher(string name, string sndnme, string lstnme, DateTime birthdate, string number, string degree = "", bool gender = true, int update = 0, int lastMatr = 10000)
        {
            bool exception = false;
            bool result;
            try
            {
                Connect();
                PreparedStatement preparedStatement;
                BoundStatement boundStatement;
                if (update > 10000)
                {
                    preparedStatement = session.Prepare("UPDATE maestro SET num_nomina  = ?,nombre_completo = ?, nombre  = ?,apellido_pat  = ?,apellido_mat  = ?,titulo  = ?,genero  = ?,fecha_naci  = ?" +
                                 " WHERE matricula = ?;");
                }
                else
                {
                    preparedStatement = session.Prepare("INSERT INTO maestro (num_nomina,nombre_completo,nombre,apellido_pat,apellido_mat,titulo,genero,fecha_naci,matricula)" +
                                " VALUES (?,?,?,?,?,?,?,?,?);");
                }
                boundStatement = preparedStatement.Bind(number,name+" "+sndnme+" "+lstnme, name, sndnme, lstnme, degree, gender, new LocalDate(birthdate.Year, birthdate.Month, birthdate.Day), (update > 10000) ? update : lastMatr);
                //...bind different parameters every time you need to execute

                //Execute the bound statement with the provided parameters
                session.Execute(boundStatement);

                Disconnect();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                exception = true;
            }
            finally
            {
                result = !exception;
            }
            return result;
        }
        public bool teacherSubjects(int teacher, int sCode, string sName, string sNick, bool remove)
        {
            bool result = false;
            Connect();
            PreparedStatement preparedStatement;
            if (remove)
            {
                preparedStatement = session.Prepare("UPDATE maestro SET materias = materias - {{clave : " + sCode.ToString() + ",nombre : '" + sName + "',alias : '" + sNick + "'}} WHERE matricula = ?; ");
            }
            else
            {
                preparedStatement = session.Prepare("UPDATE maestro SET materias = materias + {{clave : " + sCode.ToString() + ",nombre : '" + sName + "',alias : '" + sNick + "'}} WHERE matricula = ?; ");
            }
            //...bind different parameters every time you need to execute
            BoundStatement boundStatement = preparedStatement.Bind(teacher);

            //Execute the bound statement with the provided parameters
            session.Execute(boundStatement);
            Disconnect();
            return result;
        }

        //alumnos
        public IList<alumno> allStudentAll()
        {
            Connect();
            IMapper mapper = new Mapper(session);
            IEnumerable<alumno> alumnos = mapper.Fetch<alumno>("SELECT matricula,nombre,apellido_pat,apellido_mat,genero,fecha_naci,activo,carrera,pais FROM alumno");
            Disconnect();

            return alumnos.ToList();

        }
        public alumno oneStudentAll(int student)
        {
            Connect();
            IMapper mapper = new Mapper(session);
            var alumno = mapper.Single<alumno>("SELECT matricula,nombre,apellido_pat,apellido_mat,genero,fecha_naci,activo,carrera,pais FROM alumno WHERE matricula=?", student);
            Disconnect();
            return alumno;
        }
        public void deleteStudent(int student)
        {
            Connect();
            var delete = session.Prepare("UPDATE alumno SET activo = false WHERE matricula = ?");

            //...bind different parameters every time you need to execute
            var statement = delete.Bind(student);

            //Execute the bound statement with the provided parameters
            session.Execute(statement);
            Disconnect();
        }
        public bool insertStudent(string name, string mdlnme, string lstnme, DateTime birthdate, string career, string country, int ID, bool update, bool gender = true)
        {
            bool exception = false;
            bool result;
            try
            {
                Connect();
                PreparedStatement preparedStatement;
                if (update)
                {
                    preparedStatement = session.Prepare("UPDATE alumno SET nombre = ?,apellido_pat = ?,apellido_mat = ?,genero = ?,fecha_naci = ?,activo = ?,carrera = ?,pais = ?" +
                                 " WHERE matricula = ?;");
                }
                else
                {
                    preparedStatement = session.Prepare("INSERT INTO alumno (nombre,apellido_pat,apellido_mat,genero,fecha_naci,activo,carrera,pais,matricula)" +
                                " VALUES (?,?,?,?,?,?,?,?,?);");
                }

                //...bind different parameters every time you need to execute
                var boundStatement = preparedStatement.Bind(name, mdlnme, lstnme, gender, new LocalDate(birthdate.Year, birthdate.Month, birthdate.Day), true, career,country,ID);

                //Execute the bound statement with the provided parameters
                session.Execute(boundStatement);

                Disconnect();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                exception = true;
            }
            finally
            {
                result = !exception;
            }
            return result;
        }
        public IList<string> allCountryNames()
        {
            Connect();
            IMapper mapper = new Mapper(session);
            IEnumerable<string> alumnos = mapper.Fetch<string>("SELECT nombre FROM pais");
            Disconnect();

            return alumnos.ToList();

        }
        public IList<kardex> studentKardex(int student, string semester = "")
        {
            Connect();
            IMapper mapper = new Mapper(session);
            IEnumerable<kardex> kardexes;
            if (semester == "") {
                kardexes = mapper.Fetch<kardex>("SELECT nombre,matricula,materia,calificacion,semestre FROM kardex WHERE matricula = ? ALLOW FILTERING", student);
            }
            else
            {
                kardexes = mapper.Fetch<kardex>("SELECT nombre,matricula,materia,calificacion,semestre FROM kardex WHERE matricula = ? AND semestre = ? ALLOW FILTERING", student,semester);
            }
            Disconnect();

            return kardexes.ToList();

        }

        //semestres
        public IList<semestre> allSemesterAll()
        {
            Connect();
            IMapper mapper = new Mapper(session);
            IEnumerable<semestre> semestres = mapper.Fetch<semestre>("SELECT id,nombre,fecha_inicio,fecha_fin, creditos_min, creditos_max, estado FROM semestre");
            Disconnect();

            return semestres.ToList();

        }
        public semestre oneSemesterAll(Guid guid)
        {
            Connect();
            IMapper mapper = new Mapper(session);
            var semestre = mapper.Single<semestre>("SELECT id,nombre,fecha_inicio,fecha_fin, creditos_min, creditos_max, estado FROM semestre WHERE id=?", guid);
            Disconnect();
            return semestre;
        }
        public void deleteSemester(Guid guid)
        {
            Connect();
            var delete = session.Prepare("DELETE FROM semestre WHERE id = ?");

            //...bind different parameters every time you need to execute
            var statement = delete.Bind(guid);

            //Execute the bound statement with the provided parameters
            session.Execute(statement);
            Disconnect();
        }
        public bool insertSemester(short min, short max, DateTime start, DateTime end, Guid semester, string estado)
        {
            bool exception = false;
            bool result;
            try
            {
                string name = start.Year.ToString() + "-" + start.ToString("MMM").ToUpper()+ "~" + end.ToString("MMM").ToUpper();
                Connect();
                if (semester != Guid.Empty)
                {
                    var preparedStatement1 = session.Prepare("INSERT INTO semestre (nombre, fecha_inicio,fecha_fin, creditos_min, creditos_max, estado,id)" +
                                " VALUES (?,?,?,?,?,?,?);");

                    var preparedStatement2 = session.Prepare("DELETE FROM semestre WHERE id = ?");

                    session.Execute(preparedStatement2.Bind(semester));
                    session.Execute(preparedStatement1.Bind(name, new LocalDate(start.Year, start.Month, start.Day), new LocalDate(end.Year, end.Month, end.Day), min, max, estado, semester));
            
                }
                else
                {
                    var preparedStatement = session.Prepare("INSERT INTO semestre (nombre, fecha_inicio,fecha_fin, creditos_min, creditos_max, estado,id)" +
                                " VALUES (?,?,?,?,?,?,UUID());");
                    var boundStatement = preparedStatement.Bind(name, new LocalDate(start.Year, start.Month, start.Day), new LocalDate(end.Year, end.Month, end.Day), min, max, estado);
                    session.Execute(boundStatement);
                }
                

                //Execute the bound statement with the provided parameters
                

                Disconnect();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                exception = true;
            }
            finally
            {
                result = !exception;
            }
            return result;
        }
        private bool insertSemester(semestre semestre, string estado)
        {
            bool exception = false;
            bool result;
            try
            { 
                Connect();
                if (semestre.id != Guid.Empty)
                {
                    var preparedStatement1 = session.Prepare("INSERT INTO semestre (nombre, fecha_inicio,fecha_fin, creditos_min, creditos_max, estado,id)" +
                                " VALUES (?,?,?,?,?,?,?);");

                    var preparedStatement2 = session.Prepare("DELETE FROM semestre WHERE id = ?");

                    session.Execute(preparedStatement2.Bind(semestre.id));
                    session.Execute(preparedStatement1.Bind(semestre.nombre, semestre.fecha_inicio, semestre.fecha_fin, semestre.creditos_min, semestre.creditos_max, estado, semestre.id));

                }
                else
                {
                    var preparedStatement = session.Prepare("INSERT INTO semestre (nombre, fecha_inicio,fecha_fin, creditos_min, creditos_max, estado,id)" +
                                " VALUES (?,?,?,?,?,?,UUID());");
                    var boundStatement = preparedStatement.Bind(semestre.nombre, semestre.fecha_inicio, semestre.fecha_fin, semestre.creditos_min, semestre.creditos_max, estado);
                    session.Execute(boundStatement);
                }


                //Execute the bound statement with the provided parameters


                Disconnect();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                exception = true;
            }
            finally
            {
                result = !exception;
            }
            return result;
        }
        public string startNextSemester()
        {
            string text = "ERROR Ni idea que pasó";
            try
            {
                Connect();
                IMapper mapper = new Mapper(session);
                IEnumerable<semestre> semestres = mapper.Fetch<semestre>("SELECT id,nombre,fecha_inicio,fecha_fin, creditos_min, creditos_max, estado FROM semestre WHERE estado = 'En Curso' ALLOW FILTERING");
                if(semestres.Count() > 0)
                {
                    Disconnect();
                    return "ERROR: Hay un semestre activo";
                }
                else
                {

                    var candidates = mapper.Fetch<semestre>("SELECT id,nombre,fecha_inicio,fecha_fin, creditos_min, creditos_max, estado FROM semestre WHERE fecha_inicio > ? ALLOW FILTERING;", new LocalDate(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day));

                    semestre next = new semestre(Guid.Empty,"",new LocalDate(DateTime.MaxValue.Year, DateTime.MaxValue.Month, DateTime.MaxValue.Day),new LocalDate(1999,1,24),1,2,"");
                    foreach (semestre semestre in candidates)
                    {
                        next = semestre.fecha_inicio < next.fecha_inicio ? semestre : next;
                    }

                    insertSemester(next, "En Curso");

                    text = next.nombre;
                    if(next.id == Guid.Empty)
                    {
                        Disconnect();
                        return "ERROR: No hay semestres por venir";
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            finally
            {
                Disconnect();
            }
            return text;
        }
        public string endThisSemester(bool noMatter = false)
        {
            string text = "ERROR Ni idea que pasó";
            bool semester = false;
            try
            {
                bool fail = false;
                Connect();
                IMapper mapper = new Mapper(session);
                semestre semestre = mapper.First<semestre>("SELECT id,nombre,fecha_inicio,fecha_fin, creditos_min, creditos_max, estado FROM semestre WHERE estado = 'En Curso'  ALLOW FILTERING");
                semester = true;
                if (!noMatter)
                {
                    IEnumerable<kardex> kardexes = mapper.Fetch<kardex>("SELECT id,nombre,matricula,calificacion,semestre FROM kardex WHERE semestre = ? ALLOW FILTERING", semestre.nombre);

                    foreach (kardex kardex in kardexes)
                    {
                        if (kardex.calificacion == 0.0f)
                        {
                            fail = true;
                            break;
                        }
                    }
                    if (fail)
                    {
                        Disconnect();
                        return "ERROR: Aún hay alumnos sin calificaciones asignadas";
                    }
                }
                insertSemester(semestre,"Finalizado");
                text = semestre.nombre;

            }
            catch (Exception e)
            {

                text = semester ? (noMatter ? "ERROR: El semestre sin alumnos fue finalizado": "ERROR: No hay alumnos inscritos en este semestre, se recomienda contactar al Administrador. \n ¿Desea terminar el semestre de todas formas?") : "ERROR: No hay un semestre en curso";
            }
            finally
            {
                Disconnect();
            }
            return text;
        }
        public string thisSemester()
        {
            Connect();
            IMapper mapper = new Mapper(session);
            semestre semestre = mapper.First<semestre>("SELECT id,nombre,fecha_inicio,fecha_fin, creditos_min, creditos_max, estado FROM semestre WHERE estado = 'En Curso'  ALLOW FILTERING");
            Disconnect();
            return semestre.nombre;
        }

        //grupos 
        public IList<grupo> allGroupAll()
        {
            Connect();
            IMapper mapper = new Mapper(session);
            IEnumerable<grupo> grupos = mapper.Fetch<grupo>("SELECT id,cupo,  materia,  maestro,  aula,  semestre FROM grupo");
            Disconnect();

            return grupos.ToList();

        }
        public grupo oneGroupAll(Guid guid)
        {
            Connect();
            IMapper mapper = new Mapper(session);
            var grupo = mapper.Single<grupo>("SELECT id,cupo,  materia,  maestro,  aula,  semestre FROM grupo WHERE id=?", guid);
            Disconnect();
            return grupo;
        }
        public IEnumerable<horario> groupHorario(Guid uuid)
        {
            Connect();
            session.UserDefinedTypes.Define(UdtMap.For<horario>());
            var insert = session.Prepare("SELECT horario FROM grupo WHERE id = ?");
            //...bind different parameters every time you need to execute
            var statement = insert.Bind(uuid);
            //Execute the bound statement with the provided parameters
            IEnumerable<horario> horarios = session.Execute(statement).First().GetValue<horario[]>("horario");

            Disconnect();

            return horarios;

        }
        public void deleteGroup(Guid guid)
        {
            Connect();
            var delete = session.Prepare("DELETE FROM grupo WHERE id = ?");

            //...bind different parameters every time you need to execute
            var statement = delete.Bind(guid);

            //Execute the bound statement with the provided parameters
            session.Execute(statement);
            Disconnect();
        }
        public void groupHours(Guid group, LocalTime hour, bool monday, bool tuesday, bool wednesday, bool thursday, bool friday, bool saturday, bool update = false)
        {
            Connect();
            PreparedStatement preparedStatement;
            if (update)
            {
                preparedStatement = session.Prepare("DELETE horario FROM grupo WHERE id = ?; ");
            }
            else
            {
                preparedStatement = session.Prepare("UPDATE grupo SET horario = horario + {{hora : '" + hour + "',lunes : " + monday + ",martes : " + tuesday + ",miercoles : " + wednesday + ",jueves : " + thursday + ",viernes : " + friday + ",sabado : " + saturday + "}} WHERE id = ?; ");
            }
            //...bind different parameters every time you need to execute
            BoundStatement boundStatement = preparedStatement.Bind(group);

            //Execute the bound statement with the provided parameters
            session.Execute(boundStatement);
            Disconnect();
        }
        public Guid insertGroup(string teacher, string subject, string classroom, int cupo, Guid group)
        {
            bool exception = false;
            Guid result = Guid.Empty;
            try
            {
                Connect();
                if (group != Guid.Empty)
                {
                    var preparedStatement1 = session.Prepare("UPDATE grupo SET cupo = ?,materia = ?, maestro = ?, aula = ?" +
                                 " WHERE id = ?;");

             
                    session.Execute(preparedStatement1.Bind(cupo,subject,teacher,classroom,group));
                    result = group;
                }
                else
                {
                    IMapper mapper = new Mapper(session);
                    var candidates = mapper.Fetch<semestre>("SELECT id,nombre,fecha_inicio,fecha_fin, creditos_min, creditos_max, estado FROM semestre WHERE fecha_inicio > ? ALLOW FILTERING;", new LocalDate(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day));

                    semestre next = new semestre(Guid.Empty, "", new LocalDate(DateTime.MaxValue.Year, DateTime.MaxValue.Month, DateTime.MaxValue.Day), new LocalDate(1999, 1, 24), 1, 2, "");
                    foreach (semestre semestre in candidates)
                    {
                        next = semestre.fecha_inicio < next.fecha_inicio ? semestre : next;
                    }

                    result = Guid.NewGuid();
                    var preparedStatement = session.Prepare("INSERT INTO grupo (cupo, materia,maestro, aula, semestre,id)" +
                                " VALUES (?,?,?,?,?,?);");
                    var boundStatement = preparedStatement.Bind(cupo, subject, teacher, classroom,next.nombre, result);
                    session.Execute(boundStatement);
                }


                //Execute the bound statement with the provided parameters


                Disconnect();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                exception = true;
            }
            finally
            {
                result = !exception ? result : Guid.Empty;
            }
            return result;
        }
        public IEnumerable<grupo_alumno> groupStudents(Guid uuid)
        {
            Connect();
            session.UserDefinedTypes.Define(UdtMap.For<grupo_alumno>());
            var insert = session.Prepare("SELECT alumnos FROM grupo WHERE id = ?");
            //...bind different parameters every time you need to execute
            var statement = insert.Bind(uuid);
            //Execute the bound statement with the provided parameters
            IEnumerable<grupo_alumno> materias = session.Execute(statement).First().GetValue<grupo_alumno[]>("alumnos");

            Disconnect();

            return materias;

        }
        public int enrollStudentToGroup(Guid group, int sCode, string sName, float sCali, string sMateria, string semester, bool remove)
        {
            int result = 0;
            Connect();

            PreparedStatement preparedStatement1;
            PreparedStatement preparedStatement2;
            BatchStatement batch;
            if (remove)
            {
                preparedStatement1 = session.Prepare("UPDATE grupo SET alumnos = alumnos - {{matricula : " + sCode.ToString() + ",nombre : '" + sName + "',calificacion : " + sCali.ToString() + "}} WHERE id = ?; ");
                preparedStatement2 = session.Prepare("DELETE FROM kardex WHERE matricula = ? AND semestre = ? AND grupo = ?");
                batch = new BatchStatement()
                .Add(preparedStatement1.Bind(group))
                .Add(preparedStatement2.Bind(sCode, semester, group));
            }
            else
            {
                preparedStatement1 = session.Prepare("UPDATE grupo SET alumnos = alumnos + {{matricula : " + sCode.ToString() + ",nombre : '" + sName + "',calificacion : " + sCali.ToString() + "}} WHERE id = ?; ");
                preparedStatement2 = session.Prepare("INSERT INTO kardex(nombre,materia,matricula,calificacion,semestre,grupo) VALUES(?,?,?,?,?,?)");
                batch = new BatchStatement()
                .Add(preparedStatement1.Bind(group))
                .Add(preparedStatement2.Bind(sName, sMateria, sCode, sCali, semester, group));
            }
        //Execute the bound statement with the provided parameters
            session.Execute(batch);
            Disconnect();
            return result;
        }
        public int updateCalification(Guid group, int sCode, string sName, string sMateria, string semester, float sCali, bool remove)
        {
            int result = 0;
            Connect();
            PreparedStatement preparedStatement1;
            PreparedStatement preparedStatement2;
            BatchStatement batch;
            if (remove)
            {
                preparedStatement1 = session.Prepare("DELETE alumnos FROM grupo WHERE id = ?; ");
                batch = new BatchStatement()
                        .Add(preparedStatement1.Bind(group));
            }
            else
            {
                preparedStatement1 = session.Prepare("UPDATE grupo SET alumnos = alumnos + {{matricula : " + sCode.ToString() + ",nombre : '" + sName + "',calificacion : " + sCali.ToString() + "}} WHERE id = ?; ");
                preparedStatement2 = session.Prepare("UPDATE kardex SET calificacion = ? WHERE matricula = ? AND semestre = ? AND grupo = ?");
                batch = new BatchStatement()
                        .Add(preparedStatement1.Bind(group))
                        .Add(preparedStatement2.Bind( sCali,sCode, semester, group));
            }
            //Execute the bound statement with the provided parameters
            session.Execute(batch);
            Disconnect();
            return result;
        }

        //Examples
        //public void updateCommand()
        //{
        //    var ps = session.Prepare("UPDATE user_profiles SET birth=? WHERE key=?");

        //    //...bind different parameters every time you need to execute
        //    var statement = ps.Bind(new DateTime(1942, 11, 27), "hendrix");
        //    //Execute the bound statement with the provided parameters
        //    session.Execute(statement);
        //}

        //public void batchCommand()
        //{
        //    var profileStmt = session.Prepare("UPDATE user_profiles SET email=? WHERE key=?");
        //    var userTrackStmt = session.Prepare("INSERT INTO user_track (key, text, date) VALUES (?, ?, ?)");
        //    //...you should reuse the prepared statement
        //    //Bind the parameters and add the statement to the batch batch
        //    var batch = new BatchStatement()
        //      .Add(profileStmt.Bind(emailAddress, "hendrix"))
        //      .Add(userTrackStmt.Bind("hendrix", "You changed your email", DateTime.Now));
        //    //Execute the batch
        //    session.Execute(batch);
        //}

        //public void select()
        //{
        //    RowSet rows = session.Execute("select * from users");
        //    foreach (Row row in rows)
        //        Console.WriteLine("{0} {1}", row["firstname"], row["age"]);
        //}


        //SQL (to be transformed)
    }
}
