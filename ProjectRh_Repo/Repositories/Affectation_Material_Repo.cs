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
    public class Affectation_Material_Repo : Basic_Repository.BasicRepo<int, Affectation_Material>
    {
        public Affectation_Material_Repo() : base("Affectation_Materials", "Id_Affectation_Material")
        {


        }
        public override bool Delete(Affectation_Material id)
        {
            Command cmd = new Command("P_Affectation_Material_Delete", true);
            cmd.AddParameter("Id_Affectation_Material", id.Id);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Affectation_Material entity)
        {
            Command cmd = new Command("P_Training_Section_Insert", true);
            cmd.AddParameter("@Date_affectation_Material", entity.Date_affectation_Material);
            cmd.AddParameter("@Id_Material", entity.Id_Material);
            cmd.AddParameter("@Id_HR", entity.Id_HR);
            return ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(Affectation_Material data)
        {
            Command cmd = new Command("P_Affectation_Material_Update", true);
            cmd.AddParameter("Id_Affectation_Material", data.Id);
            cmd.AddParameter("Date_affectation_Material", data.Date_affectation_Material);
            cmd.AddParameter("Id_Material", data.Id_Material);
            cmd.AddParameter("Id_HR", data.Id_HR);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        protected override Affectation_Material Convert(IDataRecord dtr)
        {
            return new Affectation_Material
            {
                Id = (int)dtr["Id_Affectation_Material"],
                Date_affectation_Material = (DateTime)dtr["Date_affectation_Material"],
                Id_Material = (int)dtr["Id_Material"],
                Id_HR = (int)dtr["Id_HR"]
            };
        }
    }
}
