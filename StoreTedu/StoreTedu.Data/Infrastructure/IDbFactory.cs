using System;

namespace StoreTedu.Data.Infrastructure
{
    public interface IDbFactory: IDisposable
    {
        TeduShopDbContext Init();
    }
}