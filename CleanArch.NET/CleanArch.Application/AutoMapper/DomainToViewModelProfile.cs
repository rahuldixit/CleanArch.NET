﻿using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.AutoMapper
{
    internal class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile() {
            CreateMap<Course, CourseViewModel>();             
            
        }
    }
}
