using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Financeira.Infra.Context;
using Financeira.Domain.Enum;

namespace Financeira.Infra.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20170210133722_mysql")]
    partial class mysql
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("Financeira.Domain.Entities.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<DateTime?>("Date");

                    b.Property<string>("Observation");

                    b.Property<int>("Type");

                    b.Property<float>("Value");

                    b.HasKey("Id");

                    b.ToTable("Business");
                });
        }
    }
}
