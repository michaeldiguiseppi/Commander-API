﻿using Commander_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander_API.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }

    }
}
