﻿using AIS.API.ViewModels;
using AIS.BLL.Models;
using AutoMapper;

namespace AIS.API.Mappers
{
    public class EmployeeViewModelProfile : Profile
    {
        public EmployeeViewModelProfile()
        {
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();
        }
    }
}
