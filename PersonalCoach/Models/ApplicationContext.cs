using Microsoft.EntityFrameworkCore;
using PersonalCoach.Models.Workouts;
using PersonalCoach.Models.Diets;

namespace PersonalCoach.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ExerciseType> ExerciseTypes { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<WorkoutType> WorkoutTypes { get; set; }
        public DbSet<WorkoutProgramType> WorkoutProgramTypes { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutProgram> WorkoutPrograms { get; set; }
        public DbSet<WorkoutFrequency> WorkoutFrequencies { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DayRation> DayRations { get; set; }
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<IngridientType> IngridientTypes { get; set; }
        public DbSet<Ingridient> Ingridients { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealType> MealTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ExerciseType>().HasIndex(ext => ext.Name).IsUnique();
            builder.Entity<MuscleGroup>().HasIndex(ext => ext.Name).IsUnique();
            builder.Entity<Difficulty>().HasIndex(dif => dif.Name).IsUnique();
            builder.Entity<Equipment>().HasIndex(dif => dif.Name).IsUnique();
            builder.Entity<WorkoutType>().HasIndex(dif => dif.Name).IsUnique();
            builder.Entity<WorkoutProgramType>().HasIndex(dif => dif.Name).IsUnique();
            builder.Entity<WorkoutFrequency>().HasIndex(dif => dif.Name).IsUnique();

            builder.Entity<ExerciseWorkout>().HasKey(ew => new { ew.ExerciseId, ew.WorkoutId});

            builder.Entity<ExerciseWorkout>().HasOne(ew => ew.Exercise)
                .WithMany(e => e.ExerciseWorkouts)
                .HasForeignKey(ew => ew.ExerciseId);

            builder.Entity<ExerciseWorkout>().HasOne(ew => ew.Workout)
                .WithMany(e => e.ExerciseWorkouts)
                .HasForeignKey(ew => ew.WorkoutId);

            builder.Entity<WorkoutProgramWorkout>().HasKey(ew => new { ew.WorkoutProgramId, ew.WorkoutId });

            builder.Entity<WorkoutProgramWorkout>().HasOne(ew => ew.WorkoutProgram)
                .WithMany(e => e.WorkoutProgramWorkouts)
                .HasForeignKey(ew => ew.WorkoutProgramId);

            builder.Entity<WorkoutProgramWorkout>().HasOne(ew => ew.Workout)
                .WithMany(e => e.WorkoutProgramWorkouts)
                .HasForeignKey(ew => ew.WorkoutId);


            builder.Entity<DishIngridient>().HasKey(ew => new { ew.DishId, ew.IngridientId });

            builder.Entity<DishIngridient>().HasOne(ew => ew.Dish)
                .WithMany(e => e.DishIngridients)
                .HasForeignKey(ew => ew.DishId);

            builder.Entity<DishIngridient>().HasOne(ew => ew.Ingridient)
                .WithMany(e => e.DishIngridients)
                .HasForeignKey(ew => ew.IngridientId);

            builder.Entity<MealDish>().HasKey(ew => new { ew.MealId, ew.DishId });

            builder.Entity<MealDish>().HasOne(ew => ew.Meal)
                .WithMany(e => e.MealDishes)
                .HasForeignKey(ew => ew.MealId);

            builder.Entity<MealDish>().HasOne(ew => ew.Dish)
                .WithMany(e => e.MealDishes)
                .HasForeignKey(ew => ew.DishId);

            builder.Entity<DayRationMeal>().HasKey(ew => new { ew.DayRationId, ew.MealId });

            builder.Entity<DayRationMeal>().HasOne(ew => ew.DayRation)
                .WithMany(e => e.DayRationMeals)
                .HasForeignKey(ew => ew.DayRationId);

            builder.Entity<DayRationMeal>().HasOne(ew => ew.Meal)
                .WithMany(e => e.DayRationMeals)
                .HasForeignKey(ew => ew.MealId);
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<PersonalCoach.Models.Workouts.ExerciseWorkout> ExerciseWorkout { get; set; }

    }
}
