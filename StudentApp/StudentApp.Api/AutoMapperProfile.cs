using AutoMapper;
using StudentApp.Features.Department.Entities;
using StudentApp.Features.Department.Models;
using StudentApp.Features.Exam.Entities;
using StudentApp.Features.Exam.Models;
using StudentApp.Features.Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Features.Student.Entities.Profile, ProfileModel>();
            CreateMap<ProfileModel, Features.Student.Entities.Profile>();
            CreateMap<Exam, ExamModel>();
            CreateMap<ExamModel, Exam>();
            CreateMap<ExamReport, ExamReportModel>();
            CreateMap<ExamReportModel, ExamReport>();
            CreateMap<Department, DepartmentModel>();
            CreateMap<DepartmentModel, Department>();
        }
    }
}
