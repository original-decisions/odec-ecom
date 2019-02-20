using Microsoft.EntityFrameworkCore;

namespace odec.Server.Model.Services.Abst.Interfaces
{
    public interface IServiceOrderContext<TServiceOrderDetail> where TServiceOrderDetail : class
    {
        DbSet<TServiceOrderDetail> ServiceOrderDetails { get; set; }
    }
}