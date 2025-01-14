﻿using EFCoreRelationshipsPractice.Dtos;

namespace EFCoreRelationshipsPractice.Model
{
    public class CompanyEntity
    {
        public CompanyEntity()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ProfileEntity? Profile { get; set; }

        public List<EmployeeEntity>? EmployeeList { get; set; }
    }
}