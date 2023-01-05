using ProjectRh_DAL;
using ProjectRh_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_Repo.Repositories
{
    public class Employés_Repo : Basic_Repository.BasicRepo<int, Employés>
    {
        public Employés_Repo() :base("Employés", "Id_Em")
        {

        }
        public override bool Delete(Employés id)
        {
            Command cmd = new Command("P_Employées_DELETE", true);
            cmd.AddParameter("@Id_Em", id.Id);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Employés entity)
        {
            Command cmd = new Command("P_Employées_INSERT", true);
            cmd.AddParameter("@FirstName", entity.FirstName);
            cmd.AddParameter("@LastName", entity.LastName);
            cmd.AddParameter("@DateDeNaissance",entity.DateDeNaissance);
            cmd.AddParameter("@Fonction", entity.Fonction);
            cmd.AddParameter("@NumeroTel", entity.NumeroTel);
            cmd.AddParameter("email" , entity.email);
            return ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(Employés data)
        {
            Command cmd = new Command("P_Employées_Update", true);
            cmd.AddParameter("Id_Em",data.Id);
            cmd.AddParameter("FirstName", data.FirstName);
            cmd.AddParameter("LastName", data.LastName);
            cmd.AddParameter("DateDeNaissance", data.DateDeNaissance);
            cmd.AddParameter("Fonction", data.Fonction);
            cmd.AddParameter("NumeroTel", data.NumeroTel);
            cmd.AddParameter("email", data.email);
            return ConnectionString.ExecuteNonQuery(cmd)==1;
        }

        protected override Employés Convert(IDataRecord dtr)
        {
            return new Employés
            {
                Id =(int)dtr["Id_Em"],
                FirstName = dtr["FirstName"].ToString(),
                LastName = dtr["LastName"].ToString(),
                DateDeNaissance = (DateTime)dtr["DateDeNaissance"],
                Fonction =  dtr["Fonction"].ToString(),
                NumeroTel = dtr["NumeroTel"].ToString(),
                email = dtr["email"].ToString(),


            };
        }
    }
}
