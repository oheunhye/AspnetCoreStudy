using AspnetCoreStudy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreStudy.DataContext
{
    //Entityframework의 DbContext를 상속
    public class AspnetCoreStudyDbContext : DbContext
    {
        //마이그레이션으로 DB가 자동으로 생성됨
        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        //DB연결 커넥션
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connectionstring.com 참조
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=AspnetCoreStudy;User Id=sa;Password=sa1234;");
        }
    }
}
