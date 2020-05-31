using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace TorgObject.DomainObjects.Ports
{
    public interface IReadOnlyPechatProductRepository
    {
        Task<PechatProduct> GetMedPoint(long id);

        Task<IEnumerable<PechatProduct>> GetAllMedPoints();

        Task<IEnumerable<PechatProduct>> QueryMedPoints(ICriteria<PechatProduct> criteria);

    }

    public interface IPechatProductRepository
    {
        Task AddMedPoint(PechatProduct pechatproduct);

        Task RemoveMedPoint(PechatProduct pechatproduct);

        Task UpdateMedPoint(PechatProduct pechatproduct);
    }
}
