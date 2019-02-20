
using Microsoft.EntityFrameworkCore;

namespace odec.Server.Model.Services.Abst.Interfaces
{
    public interface IServiceContext<TService, TServiceType, TServiceReview, TServiceGood, TServiceImage>  
        where TService : class
        where TServiceType : class
        where TServiceReview : class
        where TServiceGood : class
        where TServiceImage : class
    {
        DbSet<TService> Services { get; set; }
        DbSet<TServiceType> ServiceTypes { get; set; }
        DbSet<TServiceReview> ServiceReviews { get; set; }
        DbSet<TServiceGood> ServiceGoods { get; set; }
        DbSet<TServiceImage> ServiceImages { get; set; }
    }
}
