using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FitnessFrog.Core.Domain.Data;

namespace FitnessFrog.Core.Domain.Data.Migrations
{
    [DbContext(typeof(FitnessFrogDbContext))]
    [Migration("20161110232618_updatedTable")]
    partial class updatedTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 82, DateTimeKind.Local));

                    b.Property<DateTime>("EntryDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EntryDate")
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 82, DateTimeKind.Local));

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModificationDate")
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 82, DateTimeKind.Local));

                    b.Property<int>("UserId")
                        .HasColumnName("UserId");

                    b.HasKey("DayId");

                    b.HasIndex("UserId");

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
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 90, DateTimeKind.Local));

                    b.Property<int>("DayId")
                        .HasColumnName("DayId");

                    b.Property<string>("ExerciseName")
                        .IsRequired()
                        .HasColumnName("ExerciseName")
                        .HasAnnotation("MaxLength", 64);

                    b.Property<string>("ExerciseType")
                        .IsRequired()
                        .HasColumnName("ExerciseType")
                        .HasAnnotation("MaxLength", 64);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModificationDate")
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 90, DateTimeKind.Local));

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

                    b.Property<int>("Weight")
                        .HasColumnName("Weight");

                    b.HasKey("ExerciseId");

                    b.HasIndex("DayId");

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
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 98, DateTimeKind.Local));

                    b.Property<int>("DayId")
                        .HasColumnName("DayId");

                    b.Property<int>("Fats")
                        .HasColumnName("Fats");

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModificationDate")
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 98, DateTimeKind.Local));

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
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 98, DateTimeKind.Local));

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModificationDate")
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 98, DateTimeKind.Local));

                    b.Property<DateTime>("NoteDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NoteDate")
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 98, DateTimeKind.Local));

                    b.Property<string>("NoteText")
                        .IsRequired()
                        .HasColumnName("NoteText")
                        .HasAnnotation("MaxLength", 4096);

                    b.Property<string>("NoteType")
                        .IsRequired()
                        .HasColumnName("NoteType")
                        .HasAnnotation("MaxLength", 64);

                    b.Property<int>("NoteTypeId")
                        .HasColumnName("NoteTypeId");

                    b.Property<int>("UserId")
                        .HasColumnName("UserId");

                    b.HasKey("NoteId");

                    b.HasIndex("UserId");

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
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 58, DateTimeKind.Local));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnName("EmailAddress")
                        .HasAnnotation("MaxLength", 128);

                    b.Property<bool>("Enabled")
                        .HasColumnName("Enabled");

                    b.Property<DateTime>("LastLoginDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LastLoginDate")
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 70, DateTimeKind.Local));

                    b.Property<string>("LastLoginIp")
                        .HasColumnName("LastLoginIp")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModificationDate")
                        .HasDefaultValue(new DateTime(2016, 11, 10, 18, 26, 17, 70, DateTimeKind.Local));

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
                        .WithMany("Days")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessFrog.Core.Domain.Exercise", b =>
                {
                    b.HasOne("FitnessFrog.Core.Domain.Day", "Day")
                        .WithMany("Exercises")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessFrog.Core.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessFrog.Core.Domain.Food", b =>
                {
                    b.HasOne("FitnessFrog.Core.Domain.Day", "Day")
                        .WithMany("Foods")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessFrog.Core.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessFrog.Core.Domain.Note", b =>
                {
                    b.HasOne("FitnessFrog.Core.Domain.User", "User")
                        .WithMany("Notes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
