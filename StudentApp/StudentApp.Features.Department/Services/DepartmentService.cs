using AutoMapper;
using Microsoft.Extensions.Configuration;
using StudentApp.Features.Department.Data;
using StudentApp.Features.Department.Models;
using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Features.Department.Services
{
    public class DepartmentService : IDepartmentService
    {
        readonly IMapper _mapper;
        readonly IConfiguration _config;
        readonly IDepartmentRepository _departmentRepository;
        readonly IUnitOfWork _unitOfWork;
        public DepartmentService(IMapper mapper, IConfiguration config, IDepartmentRepository departmentRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _config = config;
            _departmentRepository = departmentRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<DepartmentModel> AddDepatmentAsync(DepartmentModel model)
        {
            var department = _mapper.Map<DepartmentModel, Department.Entities.Department>(model);
            var createdDepartment = await _departmentRepository.CreateAsync(department);
            _unitOfWork.Commit();
            var createdDepartmentModel = _mapper.Map<Department.Entities.Department, DepartmentModel>(createdDepartment);
            return createdDepartmentModel;
        }
    }
}
