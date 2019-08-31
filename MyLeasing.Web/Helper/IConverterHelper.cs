using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyLeasing.Web.Controllers;
using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Models;

namespace MyLeasing.Web.Helper
{
    public interface IConverterHelper
    {
        Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew);

        PropertyViewModel ToPropertyViewModel(Property property);
        
        Task<Contract> ToContractAsync(ContractViewModel model, bool isNew);

        ContractViewModel ToContractViewModel(Contract contract);
    }
}