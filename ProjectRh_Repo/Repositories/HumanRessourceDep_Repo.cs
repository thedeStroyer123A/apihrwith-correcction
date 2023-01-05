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
    public class HumanRessourceDep_Repo : Basic_Repository.BasicRepo<int, HumanRessourceDep>
    {
        public HumanRessourceDep_Repo() : base("HumanRessourceDep", "Id_HR")
        {

        }

        public override bool Delete(HumanRessourceDep id)
        {
            Command cmd = new Command("P_HumanRessourceDep_Delete", true);
            cmd.AddParameter("@Id_HR", id.Id);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(HumanRessourceDep entity)
        {
            Command cmd = new Command("P_HumanRessourceDep_Insert", true);
            cmd.AddParameter("@HRDepartmentName", entity.HRDepartmentName);
            cmd.AddParameter("RH_manager_Id", entity.RH_manager_Id);
            cmd.AddParameter("Location_Id", entity.Location_Id);
            cmd.AddParameter("email",entity.email);
            cmd.AddParameter("IsAdmin", entity.email);
            return ConnectionString.ExecuteNonQuery(cmd);

        }

        public override bool Update(HumanRessourceDep data)
        {
            Command cmd = new Command("P_Employées_Update", true);
            cmd.AddParameter("@Id_HR", data.Id);
            cmd.AddParameter("@HRDepartmentName", data.HRDepartmentName);
            cmd.AddParameter("RH_manager_Id", data.RH_manager_Id);
            cmd.AddParameter("Location_Id", data.Location_Id);
            cmd.AddParameter("email", data.email);
            cmd.AddParameter("IsAdmin", data.IsAdmin);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        protected override HumanRessourceDep Convert(IDataRecord dtr)
        {
            return new HumanRessourceDep
            {
                Id = (int)dtr["Id_HR"],
                HRDepartmentName = dtr["HRDepartmentName"].ToString(),
                RH_manager_Id = (int)dtr["RH_manager"],
                Location_Id = (int)dtr["Location_Id"],
                email = dtr["email"].ToString(),
                IsAdmin = (bool)dtr["IsAdmin"]

            };
        }
    }
}

