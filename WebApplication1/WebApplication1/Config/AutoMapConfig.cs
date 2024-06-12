using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DTO;
using WebApplication1.Models;

namespace PetBooK.BL.Config
{
    public class AutoMapConfig : Profile
    {
        public AutoMapConfig() 
        {


            CreateMap<Employee, EmpDTO>();
            CreateMap<EmpDTO, Employee>();




            
        }
    }
}
