﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalCoach.Models;

namespace PersonalCoach.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191209045819_InitialDiets")]
    partial class InitialDiets
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonalCoach.Models.Diets.DayRation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("calories")
                        .HasColumnType("float");

                    b.Property<double>("carbs")
                        .HasColumnType("float");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("fats")
                        .HasColumnType("float");

                    b.Property<double>("proteins")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("DayRations");
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.DayRationMeal", b =>
                {
                    b.Property<int>("DayRationId")
                        .HasColumnType("int");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("DayRationId", "MealId");

                    b.HasIndex("MealId");

                    b.ToTable("DayRationMeal");
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DishTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("calories")
                        .HasColumnType("float");

                    b.Property<double>("carbs")
                        .HasColumnType("float");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("fats")
                        .HasColumnType("float");

                    b.Property<double>("proteins")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DishTypeId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.DishIngridient", b =>
                {
                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("IngridientId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("DishId", "IngridientId");

                    b.HasIndex("IngridientId");

                    b.ToTable("DishIngridient");
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.DishType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DishTypes");
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.Ingridient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngridientTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("calories")
                        .HasColumnType("float");

                    b.Property<double>("carbs")
                        .HasColumnType("float");

                    b.Property<double>("fats")
                        .HasColumnType("float");

                    b.Property<double>("proteins")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IngridientTypeId");

                    b.ToTable("Ingridients");
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.IngridientType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IngridientTypes");
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MealTypeId")
                        .HasColumnType("int");

                    b.Property<double>("calories")
                        .HasColumnType("float");

                    b.Property<double>("carbs")
                        .HasColumnType("float");

                    b.Property<double>("fats")
                        .HasColumnType("float");

                    b.Property<double>("proteins")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MealTypeId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.MealDish", b =>
                {
                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("MealId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("MealDish");
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.MealType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MealTypes");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.Difficulty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Difficulties");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseTypeId")
                        .HasColumnType("int");

                    b.Property<int>("MuscleGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("ExerciseTypeId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.ExerciseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ExerciseTypes");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.ExerciseWorkout", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Repetitions")
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.Property<int>("Timer")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId", "WorkoutId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("ExerciseWorkout");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.MuscleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("MuscleGroups");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkoutTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutTypeId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.WorkoutFrequency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("WorkoutFrequencies");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.WorkoutProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DifficultyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkoutFrequencyId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutProgramTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("WorkoutFrequencyId");

                    b.HasIndex("WorkoutProgramTypeId");

                    b.ToTable("WorkoutPrograms");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.WorkoutProgramType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("WorkoutProgramTypes");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.WorkoutProgramWorkout", b =>
                {
                    b.Property<int>("WorkoutProgramId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("WorkoutProgramId", "WorkoutId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("WorkoutProgramWorkout");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.WorkoutType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("WorkoutTypes");
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.DayRationMeal", b =>
                {
                    b.HasOne("PersonalCoach.Models.Diets.DayRation", "DayRation")
                        .WithMany("DayRationMeals")
                        .HasForeignKey("DayRationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalCoach.Models.Diets.Meal", "Meal")
                        .WithMany("DayRationMeals")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.Dish", b =>
                {
                    b.HasOne("PersonalCoach.Models.Diets.DishType", "DishType")
                        .WithMany("Dishes")
                        .HasForeignKey("DishTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.DishIngridient", b =>
                {
                    b.HasOne("PersonalCoach.Models.Diets.Dish", "Dish")
                        .WithMany("DishIngridients")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalCoach.Models.Diets.Ingridient", "Ingridient")
                        .WithMany("DishIngridients")
                        .HasForeignKey("IngridientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.Ingridient", b =>
                {
                    b.HasOne("PersonalCoach.Models.Diets.IngridientType", "IngridientType")
                        .WithMany("Ingridients")
                        .HasForeignKey("IngridientTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.Meal", b =>
                {
                    b.HasOne("PersonalCoach.Models.Diets.MealType", "MealType")
                        .WithMany("Meals")
                        .HasForeignKey("MealTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalCoach.Models.Diets.MealDish", b =>
                {
                    b.HasOne("PersonalCoach.Models.Diets.Dish", "Dish")
                        .WithMany("MealDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalCoach.Models.Diets.Meal", "Meal")
                        .WithMany("MealDishes")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.Exercise", b =>
                {
                    b.HasOne("PersonalCoach.Models.Workouts.Equipment", "Equipment")
                        .WithMany("Exercises")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalCoach.Models.Workouts.ExerciseType", "ExerciseType")
                        .WithMany("Exercises")
                        .HasForeignKey("ExerciseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalCoach.Models.Workouts.MuscleGroup", "MuscleGroup")
                        .WithMany("Exercises")
                        .HasForeignKey("MuscleGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.ExerciseWorkout", b =>
                {
                    b.HasOne("PersonalCoach.Models.Workouts.Exercise", "Exercise")
                        .WithMany("ExerciseWorkouts")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalCoach.Models.Workouts.Workout", "Workout")
                        .WithMany("ExerciseWorkouts")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.Workout", b =>
                {
                    b.HasOne("PersonalCoach.Models.Workouts.WorkoutType", "WorkoutType")
                        .WithMany("Workouts")
                        .HasForeignKey("WorkoutTypeId");
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.WorkoutProgram", b =>
                {
                    b.HasOne("PersonalCoach.Models.Workouts.Difficulty", "Difficulty")
                        .WithMany("WorkoutPrograms")
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalCoach.Models.Workouts.WorkoutFrequency", "WorkoutFrequency")
                        .WithMany("WorkoutPrograms")
                        .HasForeignKey("WorkoutFrequencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalCoach.Models.Workouts.WorkoutProgramType", "WorkoutProgramType")
                        .WithMany("WorkoutPrograms")
                        .HasForeignKey("WorkoutProgramTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalCoach.Models.Workouts.WorkoutProgramWorkout", b =>
                {
                    b.HasOne("PersonalCoach.Models.Workouts.Workout", "Workout")
                        .WithMany("WorkoutProgramWorkouts")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalCoach.Models.Workouts.WorkoutProgram", "WorkoutProgram")
                        .WithMany("WorkoutProgramWorkouts")
                        .HasForeignKey("WorkoutProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
