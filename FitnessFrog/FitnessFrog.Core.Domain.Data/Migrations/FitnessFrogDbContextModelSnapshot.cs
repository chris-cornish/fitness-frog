using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FitnessFrog.Core.Domain.Data;

namespace FitnessFrog.Core.Domain.Data.Migrations
{
    [DbContext(typeof(FitnessFrogDbContext))]
    partial class FitnessFrogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FitnessFrog.Core.Domain.Day", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DayId");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreationDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 126, DateTimeKind.Local));

                    b.Property<DateTime>("EntryDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EntryDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 126, DateTimeKind.Local));

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModificationDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 126, DateTimeKind.Local));

                    b.Property<int>("UserId")
                        .HasColumnName("UserId");

                    b.Property<int?>("UserId1");

                    b.HasKey("DayId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Days","FitnessFrog");
                });

            modelBuilder.Entity("FitnessFrog.Core.Domain.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ExerciseId");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreationDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 136, DateTimeKind.Local));

                    b.Property<int>("DayId")
                        .HasColumnName("DayId");

                    b.Property<int?>("DayId1");

                    b.Property<string>("ExerciseType")
                        .IsRequired()
                        .HasColumnName("ExerciseType")
                        .HasAnnotation("MaxLength", 64);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModificationDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 136, DateTimeKind.Local));

                    b.Property<int>("Reps")
                        .HasColumnName("Reps");

                    b.Property<int>("Sets")
                        .HasColumnName("Sets");

                    b.Property<string>("UnitType")
                        .IsRequired()
                        .HasColumnName("UnitType")
                        .HasAnnotation("MaxLength", 64);

                    b.Property<int>("UserId")
                        .HasColumnName("UserId");

                    b.Property<bool>("Weight")
                        .HasColumnName("Weight");

                    b.HasKey("ExerciseId");

                    b.HasIndex("DayId");

                    b.HasIndex("DayId1");

                    b.HasIndex("UserId");

                    b.ToTable("Exercises","FitnessFrog");
                });

            modelBuilder.Entity("FitnessFrog.Core.Domain.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FoodId");

                    b.Property<int>("Calories")
                        .HasColumnName("Calories");

                    b.Property<int>("Carbs")
                        .HasColumnName("Carbs");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreationDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 146, DateTimeKind.Local));

                    b.Property<int>("DayId")
                        .HasColumnName("DayId");

                    b.Property<int?>("DayId1");

                    b.Property<int>("Fats")
                        .HasColumnName("Fats");

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModificationDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 146, DateTimeKind.Local));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasAnnotation("MaxLength", 64);

                    b.Property<int>("Proteins")
                        .HasColumnName("Proteins");

                    b.Property<int>("UserId")
                        .HasColumnName("UserId");

                    b.HasKey("FoodId");

                    b.HasIndex("DayId");

                    b.HasIndex("DayId1");

                    b.HasIndex("UserId");

                    b.ToTable("Foods","FitnessFrog");
                });

            modelBuilder.Entity("FitnessFrog.Core.Domain.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NoteId");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreationDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 152, DateTimeKind.Local));

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModificationDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 152, DateTimeKind.Local));

                    b.Property<DateTime>("NoteDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NoteDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 152, DateTimeKind.Local));

                    b.Property<string>("NoteText")
                        .IsRequired()
                        .HasColumnName("NoteText")
                        .HasAnnotation("MaxLength", 4096);

                    b.Property<string>("NoteType")
                        .IsRequired()
                        .HasColumnName("NoteType")
                        .HasAnnotation("MaxLength", 64);

                    b.Property<string>("NoteTypeId")
                        .IsRequired()
                        .HasColumnName("NoteTypeId");

                    b.Property<int>("UserId")
                        .HasColumnName("UserId");

                    b.Property<int?>("UserId1");

                    b.HasKey("NoteId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Notes","FitnessFrog");
                });

            modelBuilder.Entity("FitnessFrog.Core.Domain.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreationDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 101, DateTimeKind.Local));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnName("EmailAddress")
                        .HasAnnotation("MaxLength", 128);

                    b.Property<bool>("Enabled")
                        .HasColumnName("Enabled");

                    b.Property<DateTime>("LastLoginDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LastLoginDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 109, DateTimeKind.Local));

                    b.Property<string>("LastLoginIp")
                        .HasColumnName("LastLoginIp")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModificationDate")
                        .HasDefaultValue(new DateTime(2016, 10, 9, 0, 16, 33, 108, DateTimeKind.Local));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasAnnotation("MaxLength", 64);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("Password")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordRecoveryAnswer")
                        .HasColumnName("PasswordRecoveryAnswer")
                        .HasAnnotation("MaxLength", 64);

                    b.Property<string>("PasswordRecoveryQuestion")
                        .HasColumnName("PasswordRecoveryQuestion")
                        .HasAnnotation("MaxLength", 128);

                    b.HasKey("UserId");

                    b.ToTable("Users","FitnessFrog");
                });

            modelBuilder.Entity("FitnessFrog.Core.Domain.Day", b =>
                {
                    b.HasOne("FitnessFrog.Core.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("FitnessFrog.Core.Domain.User")
                        .WithMany("Days")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("FitnessFrog.Core.Domain.Exercise", b =>
                {
                    b.HasOne("FitnessFrog.Core.Domain.Day", "Day")
                        .WithMany()
                        .HasForeignKey("DayId");

                    b.HasOne("FitnessFrog.Core.Domain.Day")
                        .WithMany("Exercises")
                        .HasForeignKey("DayId1");

                    b.HasOne("FitnessFrog.Core.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FitnessFrog.Core.Domain.Food", b =>
                {
                    b.HasOne("FitnessFrog.Core.Domain.Day", "Day")
                        .WithMany()
                        .HasForeignKey("DayId");

                    b.HasOne("FitnessFrog.Core.Domain.Day")
                        .WithMany("Foods")
                        .HasForeignKey("DayId1");

                    b.HasOne("FitnessFrog.Core.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FitnessFrog.Core.Domain.Note", b =>
                {
                    b.HasOne("FitnessFrog.Core.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("FitnessFrog.Core.Domain.User")
                        .WithMany("Notes")
                        .HasForeignKey("UserId1");
                });
        }
    }
}
