using Microsoft.EntityFrameworkCore;

namespace odec.Server.Model.Services.Abst.Interfaces
{
    public interface IServiceOrderDetailContext<TServiceOrderDetail> where TServiceOrderDetail : class
    {
        DbSet<TServiceOrderDetail> ServiceOrderDetails { get; set; }
    }
}