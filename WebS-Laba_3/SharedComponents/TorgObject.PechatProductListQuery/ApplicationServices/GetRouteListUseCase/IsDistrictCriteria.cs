using TorgObject.DomainObjects;
using TorgObject.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TorgObject.ApplicationServices.GetMedPointListUseCase
{
    public class IsDistrictCriteria : ICriteria<PechatProduct>
    {
        public string IsDistrict { get; }

        public IsDistrictCriteria(string isdistrict)
            => IsDistrict = isdistrict;

        public Expression<Func<PechatProduct, bool>> Filter
            => (ds => ds.IsDistrict == IsDistrict);
    }
}
