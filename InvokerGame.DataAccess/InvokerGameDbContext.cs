using InvokerGame.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvokerGame.DataAccess
{
    public class InvokerGameDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-16MU2EN\SQLEXPRESS; Database=InvokerGame;uid=tolgasozbir;pwd=1234;");
        }

        public DbSet<TimerScore> TimerScores { get; set; }
    }
}
