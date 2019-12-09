# PersonalCoach

# REST API

# Instruction
---
# WorkoutTypes
| Action | Method | Command | JSON properties required |
| - | - | - | - |
| Get all workout types | GET | http://www.example.com/api/WorkoutTypes |
| Get specific workout type | GET | http://www.example.com/api/WorkoutTypes/id |
| Create workout program type | POST | http://www.example.com/api/WorkoutTypes | name |
| Update workout type | PUT | http://www.example.com/api/WorkoutTypes/id | name |
| Delete workout type | DELETE | http://www.example.com/api/WorkoutTypes/id |
# WorkoutProgramTypes
| Action | Method | Command | JSON properties required |
| - | - | - | - |
| Get all workout program types | GET | http://www.example.com/api/WorkoutProgramTypes |
| Get specific workout program type | GET | http://www.example.com/api/WorkoutProgramTypes/id |
| Create workout program type | POST | http://www.example.com/api/WorkoutProgramTypes | name |
| Update workout program type | PUT | http://www.example.com/api/WorkoutProgramTypes/id | name |
| Delete workout program type | DELETE | http://www.example.com/api/WorkoutProgramTypes/id |
# MuscleGroups
| Action | Method | Command | JSON properties required |
| - | - | - | - |
| Get all muscle groups | GET | http://www.example.com/api/MuscleGroups |
| Get specific muscle group | GET | http://www.example.com/api/MuscleGroups/id |
| Create muscle group | POST | http://www.example.com/api/MuscleGroups | name | 
| Update muscle group | PUT | http://www.example.com/api/MuscleGroups/id | name |
| Delete muscle group | DELETE | http://www.example.com/api/MuscleGroups/id |
# Exercises
| Action | Method | Command | JSON properties required |
| - | - | - | - |
| Get all exercises | GET | http://www.example.com/api/Exercises |
| Get exercises by search criteria | GET | http://www.example.com/api/Exercises?muscleGroup |
| Get specific exercise | GET | http://www.example.com/api/Exercises/id |
| Create exercise | POST | http://www.example.com/api/Exercises | name, exerciseTypeId, equipmentId, muscleGroupId, description | 
| Update exercise | PUT | http://www.example.com/api/Exercises/id | name, exerciseTypeId, equipmentId, muscleGroupId, description |
| Delete exercise | DELETE | http://www.example.com/api/Exercises/id |
# DayRations
| Action | Method | Command | JSON properties required |
| - | - | - | - |
| Get day rations by search criteria | GET | http://www.example.com/api/DayRations?dayCount=7&calories=2000 |
| Get specific day ration | GET | http://www.example.com/api/DayRations/id |
| Create day ration | POST | http://www.example.com/api/DayRations | description, proteins, fats, carbs, calories | 
| Update day ration | PUT | http://www.example.com/api/DayRations/id | description, proteins, fats, carbs, calories |
| Delete day ration | DELETE | http://www.example.com/api/DayRations/id |


etc.
