using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                                 // (Initially NULL; NO DBManager Object is created yet)
                       

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        //checks the username/password and returns the priviledges associated with this user
        //Returns 0 in case of error
        public int CheckPassword_Basic(string username, string password)
        {
            //Query the DB to check for username/password
            string query = "SELECT priv from Users_basic where username = '" + username + "' and password='" + password + "';";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return (int)p;
        }

        public int getssn(string username,string pass)//get ssn of manager
        {
            string query = "SELECT SSN from Manager where username = '" + username + "' and pass='" + pass + "';";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return (int)p;

            
        }
        public DataTable CheckPharmacyhasmanager(int code)//check if the code 
        {
            string query = "SELECT* FROM Manager WHERE PhCode = " + code +  ";";
           return dbMan.ExecuteReader(query);
        }

        public int getPHcodeformanager(int ss)//get pharmacy code for manager
        {
            string query = "SELECT PhCode FROM Manager WHERE  SSN =" + ss + ";";
            object p = dbMan.ExecuteScalar(query);
            return (int) p;

        }
        
        public DataTable ViewEmployees(int code)//manager can see all employees of his pharmacy
        {
            string query = "SELECT * FROM Employee where PhCode ="+code+";";
            return dbMan.ExecuteReader(query);
            
        }


        public DataTable Viewdrugs(int code)//manager can see all drugs of his pharmacy
        {
            string query = "select * from Drug where Name in(select DrugName from contain where [PhCode]="+code+");";
            return dbMan.ExecuteReader(query);

        }


        public DataTable Viewinstruments(int code)//manager can see all instruments of his pharmacy
        {
            string query = "select * from Instrument where PhCode =" + code + ";";
            return dbMan.ExecuteReader(query);

        }

        public DataTable Viewdonors(int code)//manager can see all donors for the patients of his pharmacy
        {
            string query = "select * from Donor where ID in(select DonorId from Donate where PatientID in(select id from Patient where PHcode =" + code + "));";
            return dbMan.ExecuteReader(query);

        }
        //insert employee**********************************************************************

        public int InsertEmp(string Name, string UserName, string Pass, int Phone,string Addr,string Email ,int SSN,int Salary,string Job,int Age,int PhCode)
        {
            string query = "INSERT INTO Employee (Name,UserName,Pass,Phone,Addr,Email,SSN,Salary,Job,Age,PhCode) " +
                            "Values ('" + Name + "','" + UserName + "','" + Pass + "',"+ Phone + " ,'"+ Addr + "','"+ Email + "',"+ SSN + ","+ Salary + ",'"+ Job + "',"+ Age + ","+ PhCode + ");";
            return dbMan.ExecuteNonQuery(query);
        }

  /// ////////////////////////////////update employees related things*************************************************
        public DataTable getEMPname(int code)
        {
            string query = "select Name from Employee where PhCode=" + code + ";";
            return dbMan.ExecuteReader(query);

        }

        

        public DataTable getEMPssn(int code)
        {
            string query = "select SSN from Employee where PhCode=" + code + ";";
            return dbMan.ExecuteReader(query);

        }
      
        public int checkNameSSn(string name, string ssn,int code)
        {
            Convert.ToInt32(ssn);
            string query = "select * from Employee where PhCode=" + code + "and SSN="+ssn+"and Name='"+name+"';";
            DataTable t= dbMan.ExecuteReader(query);
            if (t == null)   //not found
                return 0;
            return 1;
        }

        public string getEmpnamebySSN(int ssn)
        {
            string query = "select Name from Employee where  SSN=" + ssn + ";";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string getEmpUSERNAMEbySSN(int ssn)
        {
            string query = "select UserName from Employee where  SSN=" + ssn + ";";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string getEmpPassbySSN(int ssn)
        {
            string query = "select Pass from Employee where  SSN=" + ssn + ";";
            return (string)dbMan.ExecuteScalar(query);
        }



        public string getEmpPassbyemail(string email)
        {
            string query = "select Pass from Employee where  Email='" + email + "';";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string getEmpUsernamebyemail(string email)
        {
            string query = "select UserName from Employee where  Email='" + email + "';";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string getEmpPhonebySSN(int ssn)
        {
            string query = "select Phone from Employee where  SSN=" + ssn + ";";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string getEmpAddrbySSN(int ssn)
        {
            string query = "select Addr from Employee where  SSN=" + ssn + ";";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string getEmpEmailbySSN(int ssn)
        {
            string query = "select Email from Employee where  SSN=" + ssn + ";";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string getEmpSalarybySSN(int ssn)
        {
            string query = "select Salary from Employee where  SSN=" + ssn + ";";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string getEmpJobbySSN(int ssn)
        {
            string query = "select Job from Employee where  SSN=" + ssn + ";";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string getEmpAgebySSN(int ssn)
        {
            string query = "select Age from Employee where  SSN=" + ssn + ";";
            return (string)dbMan.ExecuteScalar(query);
        }


        public int UpdateEmployee(string Name, string UserName, string Pass, string Phone, string Addr, string Email, string Salary, string Job,int ss)
        {
            int ph = Convert.ToInt32(Phone);
            int sal = Convert.ToInt32(Salary);
            string query = "UPDATE Employee SET " +
                "Name='" + Name + "'," +
                "UserName='" + UserName + "'," +
                "Pass='" + Pass + "'," +
                "Phone=" + ph + "," +
                "Addr='" + Addr + "'," +
                "Email='" + Email + "'," +
                "Salary=" + sal + "," +
                "Job='" + Job + "' where SSN ="+ss +";" ;
            return dbMan.ExecuteNonQuery(query);
        }


/// ///////////////////////////////supplier related things//////////////////////////////////////////////////////


        public DataTable getsupnames()
        {
            string query = "select Name from Supplier ;";
            return dbMan.ExecuteReader(query);

        }

        public DataTable getdrugnames()
        {
            string query = "select Name from Drug ;";
            return dbMan.ExecuteReader(query);

        }
        public int getsupIDbyName(string name)
        {
            string query = "select ID from Supplier where Name='"+ name+"' ;";
            return (int) dbMan.ExecuteScalar(query);


        }
        public int insertsupply(int id,int code,string name,string qty)
        {
            int q = Convert.ToInt32(qty);
            string query = "INSERT INTO Supply (SupplierID,PhCode,DrugName,quantity) " +
                "Values (" + id + "," + code + ",'" + name + "'," + q +");";
            return dbMan.ExecuteNonQuery(query);

        }


        //view applicants********************************************************************************************
        public DataTable viewAPPlicantnames(int code)
        {
            string query = "select Name from Applicant where PhCode="+code+" ;";
            return dbMan.ExecuteReader(query);

        }

        public int getApplicantphone(string name)
        {
                    string query = "select Phone from Applicant where Name='" + name + "' ;";
            return (int) dbMan.ExecuteScalar(query);

    }

        public string getApplicantaddr(string name)
        {
            string query = "select Addr from Applicant where Name='" + name + "' ;";
            return (string)dbMan.ExecuteScalar(query);

        }


        public string getApplicantEmail(string name)
        {
            string query = "select Email from Applicant where Name='" + name + "' ;";
            return (string)dbMan.ExecuteScalar(query);

        }

        public int getApplicantSSN(string name)
        {
            string query = "select SSN from Applicant where Name='" + name + "' ;";
            return (int)dbMan.ExecuteScalar(query);

        }
        public string getApplicantjob(string name)
        {
            string query = "select Job from Applicant where Name='" + name + "' ;";
            return (string)dbMan.ExecuteScalar(query);

        }

        public string getApplicantGender(string name)
        {
            string query = "select Gender from Applicant where Name='" + name + "' ;";
            return (string)dbMan.ExecuteScalar(query);

        }

        public int getApplicantage(string name)
        {
            string query = "select Age from Applicant where Name='" + name + "' ;";
            return (int)dbMan.ExecuteScalar(query);

        }


        public string getApplicantDegree(string name)
        {
            string query = "select Degree from Applicant where Name='" + name + "' ;";
            return (string)dbMan.ExecuteScalar(query);

        }

        public string getApplicantCollege(string name)
        {
            string query = "select College from Applicant where Name='" + name + "' ;";
            return (string)dbMan.ExecuteScalar(query);

        }

        public int getApplicantPHCODE(string Email) {
            string query = "select PhCode from Applicant where Email='" + Email + "' ;";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int deleteAPPlicant(string email)
        {
            string query = "delete  from Applicant where Email='" + email + "' ;";
            return dbMan.ExecuteNonQuery(query);

        }


    
        /// ///////////////////////////////////delete emp**************************************************************************************
 
        public int deleteEmployee(string name,string mail,int code)
        {
            string query = "delete  from Employee where Name='" + name + "' and Email='"+ mail+ "' and PhCode="+code+" ;";
            return dbMan.ExecuteNonQuery(query);

        }
        public DataTable getEMPemails(int code)
        {
            string query = "select Email from Employee where PhCode="+code+" ;";
            return dbMan.ExecuteReader(query);
        }


        //get all pharmacy info*******************************************************************************************
        public string getpharmacyname(int code)
        {
            string query = "select Name from Pharmacy where Code="+ code+";";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string getpharmacyloc(int code)
        {
            string query = "select Loc from Pharmacy where Code=" + code + ";";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string getpharmacyEmail(int code)
        {
            string query = "select Email from Pharmacy where Code=" + code + ";";
            return (string)dbMan.ExecuteScalar(query);
        }
        public TimeSpan getpharmacyopentime(int code)
        {
            string query = "select OpenTime from Pharmacy where Code=" + code + ";";
            return (TimeSpan)dbMan.ExecuteScalar(query);
        }
        public TimeSpan getpharmacyCloseTime(int code)
        {
            string query = "select CloseTime from Pharmacy where Code=" + code + ";";
            return (TimeSpan)dbMan.ExecuteScalar(query);
        }

//update pharmrcy info**************************************************************************************

            public int updatepharmacy(int code,string name,string loc,string email,TimeSpan Otime,TimeSpan Ctime)
        {
            string query = "UPDATE Pharmacy set Name='"+name+"', Loc='"+loc+"',Email='"+email+"',OpenTime='"+Otime+"',CloseTime='"+Ctime+"' where Code="+code+";";
            return dbMan.ExecuteNonQuery(query);
        }
//**************************************************************************************************
        //insert into user basic

            public int insertintouserbasic(string username,string pass,int priv)
        {
            string query = "insert into Users_basic values('"+username+"','"+pass+"',"+priv+");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateuserbasic(string newusername, string newpass,string oldusername,string oldpass)
        {
            string query = "update Users_basic set username ='" + newusername + "',password='" + newpass + "' where username = '" + oldusername + "' and password ='"+oldpass+"';";
            return dbMan.ExecuteNonQuery(query);
        }
        //update manager info*******************************
        public string getmanagerusername(int phcode)
        {
            string query = "select UserName from Manager where PhCode="+phcode+";";
            return (string)dbMan.ExecuteScalar(query);

        }


        public string getmanagerpass(int phcode)
        {
            string query = "select pass from Manager where PhCode=" + phcode + ";";
            return (string)dbMan.ExecuteScalar(query);

        }
        public string getmanagername(int phcode)
        {
            string query = "select Name from Manager where PhCode=" + phcode + ";";
            return (string)dbMan.ExecuteScalar(query);

        }
        public int getmanagerphone(int phcode)
        {
            string query = "select Phone from Manager where PhCode=" + phcode + ";";
            return (int)dbMan.ExecuteScalar(query);

        }
        public string getmanagerAddr(int phcode)
        {
            string query = "select Addr from Manager where PhCode=" + phcode + ";";
            return (string)dbMan.ExecuteScalar(query);

        }
        public string getmanagerEmail(int phcode)
        {
            string query = "select Email from Manager where PhCode=" + phcode + ";";
            return (string)dbMan.ExecuteScalar(query);

        }
        public int getmanagersalary(int phcode)
        {
            string query = "select Salary from Manager where PhCode=" + phcode + ";";
            return (int)dbMan.ExecuteScalar(query);

        }
        public string getmanagerJob(int phcode)
        {
            string query = "select Job from Manager where PhCode=" + phcode + ";";
            return (string)dbMan.ExecuteScalar(query);

        }
        public int getmanagerAge(int phcode)

        {
            string query = "select Age from Manager where PhCode=" + phcode + ";";
            return (int) dbMan.ExecuteScalar(query);

        }
        public int getmanagerExpYears(int phcode)

        {
            string query = "select ExpYears from Manager where PhCode=" + phcode + ";";
            return (int) dbMan.ExecuteScalar(query);

        }   

        public int updatemanagerinfo(string name,string username,string pass,string phone,string addr,string email,string salary,string job,string age,string expyears,int code)
        {
            int pphhone = Convert.ToInt32(phone);
            int sal = Convert.ToInt32(salary);
            int agge = Convert.ToInt32(age);
            int experienceyears = Convert.ToInt32(expyears);
            string query = "update Manager set Name ='"+name+"',UserName ='"+ username +"',pass='"+pass+"',Phone="+pphhone+",Addr='"+addr+"',Email='"+email+"', Salary="+sal+", Job='"+job+"', Age="+agge+",  ExpYears="+experienceyears+"where PhCode= "+code+";";

            return dbMan.ExecuteNonQuery(query);

        }

        //ADMIN FUNCS



        public int insertnewpharmacy(string name,string Code, string Loc, string Email, string OpenTime , string CloseTime, string  Rating)

            {
        int code = Convert.ToInt32(Code);
        TimeSpan open = TimeSpan.Parse( OpenTime);
        TimeSpan close = TimeSpan.Parse(CloseTime);
        int rat = Convert.ToInt32(Rating);
        string query = "insert into Pharmacy values('"+name+"',"+code+",'"+Loc+"','"+Email+"','"+open+"','"+close+"',"+rat+"  );";
        return dbMan.ExecuteNonQuery(query);
            }


        public int insertnewmanager( string Name , string UserName,
            string pass, string Phone, string Addr, string Email, string SSN, 
            string Salary, string Job, string Age, string PhCode, string ExpYears)
        {
            int phn = Convert.ToInt32(Phone);
            int ss = Convert.ToInt32(SSN);
            int sal = Convert.ToInt32(Salary);
            int ag = Convert.ToInt32(Age);
            int pcode = Convert.ToInt32(PhCode);
            int exp = Convert.ToInt32(ExpYears);
            string query = "insert into Manager values('"+ Name + "','"+UserName+"','"+pass+"',"+phn+",'"+Addr+"','" +Email+"',"+ss+","+sal+",'"+Job+"',"+ag+","+pcode+","+exp+");";
            return dbMan.ExecuteNonQuery(query); 
        }
       public DataTable checkpharmacycodeexist(int code)
        {
            string query = "select * from Pharmacy where Code =" + code + ";";
            return dbMan.ExecuteReader(query);
        }


        public int addnewadmin(string username,string pass)
        {
            string query = "insert into Users_basic values('" + username + "','" + pass + "',10);";
            return dbMan.ExecuteNonQuery(query);
        }
        public int addnewdrug(string name,string type,string price,string expdate)
        {
            int t = Convert.ToInt32(price);
            DateTime ex = Convert.ToDateTime(expdate);
            string query = "insert into Drug values('"+name+"','"+type +"',"+t+",'"+ex+"');";
            return dbMan.ExecuteNonQuery(query);
        }


        public int addnewsupplier(string name, string phone, string email, string id)
        {
            int t = Convert.ToInt32(id);
            int ph = Convert.ToInt32(phone);
            string query = "insert into Supplier values('" + name + "'," + ph + ",'" + email + "'," + t + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getpharmacynames()
        {
            string query = "select Name from Pharmacy ;";
            return dbMan.ExecuteReader(query);

        }

        public int deletepharmacy(string name)
        {
            string query = "delete from Pharmacy where Name='"+name+"';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int getpharmacycodebyname(string name)
        {
            string query = "select Code from Pharmacy where Name ='"+name+"';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int deletemanager(int code)
        {
            string query = "delete from Manager where PhCode="+code+";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int deletefromuserbasic(string user,string pass)
        {
            string query = "delete from Users_basic where username='" + user + "' and password='"+pass+"';";
            return dbMan.ExecuteNonQuery(query);

        }

        public int addinstrumentbyadmin(string name,string cat,string type,string id)
        {
            int i = Convert.ToInt32(id);
            string query = "insert into Instrument(Name,Category,Type,ID) values('"+name+"','"+cat+"','"+type+"',"+i+");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int adddonorbyadmin(string name,string username,string pass,string phone,string email,string id)
        {
            int p = Convert.ToInt32(phone);
            int d = Convert.ToInt32(id);
            string query = "insert into Donor values('"+name+ "','"+username+"','"+pass+"',"+p+",'"+email+"',"+d+");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addpatientbyadmin(string name, string username, string pass, string phone,string addr, string email, string id,string ill,string code)

        {
            int p = Convert.ToInt32(phone);
            int d = Convert.ToInt32(id);
            int ph = Convert.ToInt32(code);
            string query = "insert into Patient values('" + name + "','" + username + "','" + pass + "'," + p + ",'"+addr+"','" + email + "',"+d+",'" + ill + "',"+ph+");";
            return dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


    }
}


    
