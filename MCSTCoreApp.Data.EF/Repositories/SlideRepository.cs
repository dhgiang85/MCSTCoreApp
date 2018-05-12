using System;
using System.Collections.Generic;
using System.Text;
using MCSTCoreApp.Data.Entities;
using MCSTCoreApp.Data.IRepositories;

namespace MCSTCoreApp.Data.EF.Repositories
{
    public class SlideRepository : EFRepository<Slide, int>, ISlideRepository
    {
        public SlideRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
