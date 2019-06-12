﻿// <auto-generated />
using System;
using AccountOwnerServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountOwnerServer.Data.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20190612001547_Initial Create")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccountOwnerServer.Data.Entities.Account", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountType")
                        .IsRequired();

                    b.Property<DateTime>("DateCreated");

                    b.Property<Guid>("OwnerId");

                    b.HasKey("AccountId");

                    b.ToTable("account");
                });

            modelBuilder.Entity("AccountOwnerServer.Data.Entities.Owner", b =>
                {
                    b.Property<Guid>("OwnerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("OwnerId");

                    b.ToTable("owner");
                });
#pragma warning restore 612, 618
        }
    }
}
