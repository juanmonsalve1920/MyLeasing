using Microsoft.AspNetCore.Mvc.Rendering;
using MyLeasing.Web.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyLeasing.Web.Helper
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboLessees()
        {
            var List = _dataContext.Lessees.Select(l => new SelectListItem
            {
                Text = l.User.FullNameWithDocument,
                Value = $"{l.Id}"
            })
                .OrderBy(l => l.Text)
                .ToList();

            List.Insert(0, new SelectListItem
            {
                Text = "(Select a Lessee...)",
                Value = "0"
            });

            return List;
        }


        public IEnumerable<SelectListItem> GetComboPropertyTypes()
        {
            var List = _dataContext.PropertyTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = $"{pt.Id}"
            })
                .OrderBy(pt => pt.Text)
                .ToList();

            List.Insert(0, new SelectListItem
            {
                Text = "(Select a property type...)",
                Value = "0"
            });

            return List;
        }
    }

    
}
