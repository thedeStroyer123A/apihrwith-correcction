using ProjectRh_BLL.Models;
using ProjectRh_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Mapper
{
    public static class MapperEmployésBLL
    {
        public static Employés_BLL E_BLLtoE_Repo(this Employés em_repo )
        {
            return new Employés_BLL
            {
                Id = em_repo.Id,
                FirstName = em_repo.FirstName,
                LastName = em_repo.LastName,
                DateDeNaissance = em_repo.DateDeNaissance,
                Fonction = em_repo.Fonction,
                NumeroTel = em_repo.NumeroTel,
                email = em_repo.email

            };

           
        }
        public static Employés E_RepotoE_BLL(this Employés_BLL Em)
        {
            return new Employés
            {
                Id=Em.Id,
                FirstName=Em.FirstName,
                LastName=Em.LastName,
                DateDeNaissance=Em.DateDeNaissance,
                Fonction=Em.Fonction,
                NumeroTel=Em.NumeroTel,
                email=Em.email
                
            };


        }

    }



}
