# PersonalCoach

# REST API

# Manual
---
# WorkoutTypes
| Action | Method | Command | JSON properties required |
| - | - | - | - |
| Get all workout types | GET | http://www.example.com/api/WorkoutTypes |
| Get specific workout type | GET | http://www.example.com/api/WorkoutTypes/id |
| Create workout program type | POST | http://www.example.com/api/WorkoutTypes | workoutType |
| Update workout type | PUT | http://www.example.com/api/WorkoutTypes/id | id, workoutType |
| Delete workout type | DELETE | http://www.example.com/api/WorkoutTypes/id | id | 
# WorkoutProgramTypes
| Action | Method | Command | JSON properties required |
| - | - | - | - |
| Get all workout program types | GET | http://www.example.com/api/WorkoutProgramTypes |
| Get specific workout program type | GET | http://www.example.com/api/WorkoutProgramTypes/id |
| Create workout program type | POST | http://www.example.com/api/WorkoutProgramTypes | workoutProgramType |
| Update workout program type | PUT | http://www.example.com/api/WorkoutProgramTypes/id | id, workoutProgramType |
| Delete workout program type | DELETE | http://www.example.com/api/WorkoutProgramTypes/id | id |
# MuscleGroups
| Action | Method | Command | JSON properties required |
| - | - | - | - |
| Get all muscle groups | GET | http://www.example.com/api/MuscleGroups |
| Get specific muscle group | GET | http://www.example.com/api/MuscleGroups/id |  id |
| Create muscle group | POST | http://www.example.com/api/MuscleGroups | muscleGroup | 
| Update muscle group | PUT | http://www.example.com/api/MuscleGroups/id | id, muscleGroup |
| Delete muscle group | DELETE | http://www.example.com/api/MuscleGroups/id |  id |
# Exercises
| Action | Method | Command | JSON properties required |
| - | - | - | - |
| Get all exercises | GET | http://www.example.com/api/Exercises |
| Get exercises by search criteria | GET | http://www.example.com/api/Exercises?muscleGroup |
| Get specific exercise | GET | http://www.example.com/api/Exercises/id |  id |
| Create exercise | POST | http://www.example.com/api/Exercises | exercise | 
| Update exercise | PUT | http://www.example.com/api/Exercises/id | id, exercise |
| Delete exercise | DELETE | http://www.example.com/api/Exercises/id |  id |
# DayRations
| Action | Method | Command | JSON properties required |
| - | - | - | - |
| Get day rations by search criteria | GET | http://www.example.com/api/DayRations?dayCount=7&calories=2000 |
| Get specific day ration | GET | http://www.example.com/api/DayRations/id |  id |
| Create day ration | POST | http://www.example.com/api/DayRations | dayRation | 
| Update day ration | PUT | http://www.example.com/api/DayRations/id | id, dayRation |
| Delete day ration | DELETE | http://www.example.com/api/DayRations/id |  id |


etc.
