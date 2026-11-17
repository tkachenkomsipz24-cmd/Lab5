from dataclasses import dataclass


@dataclass
class Student:
    surname: str
    group: str
    grade: int   # середній бал
    year: int    # рік вступу


students = [
    Student("Ткаченко", "ІПЗ-3/1", 85, 2024),
    Student("Бондар",   "ІПЗ-3/2", 92, 2023),
    Student("Іваненко", "ІПЗ-3/1", 85, 2024),
    Student("Коваль",   "ІПЗ-3/2", 78, 2024),
    Student("Сидоренко","ІПЗ-3/1", 85, 2023),
    Student("Мельник",  "ІПЗ-3/2", 92, 2024),
    Student("Гриценко", "ІПЗ-3/1", 78, 2023),
    Student("Дяченко",  "ІПЗ-3/2", 85, 2023),
]


def printAll(title, items):
    print(f"=== {title} ===")
    for s in items:
        print(f"{s.surname:<10} | {s.group:<8} | {s.grade} | {s.year}")
    print()


# TODO 
by_surname = sorted(students, key=lambda s: s.surname)
printAll("1. За прізвищем (за абеткою)", by_surname)

# TODO 
by_grade = sorted(students, key=lambda s: s.grade, reverse=True)
printAll("2. За балом (від вищого до нижчого)", by_grade)

# TODO
by_group_and_grade = sorted(students, key=lambda s: (s.group, -s.grade))
printAll("3. За групою (за абеткою), всередині — за балом (від вищого)", by_group_and_grade)

# Додатково 
by_grade_and_surname = sorted(students, key=lambda s: (-s.grade, s.surname))
printAll("Додатково (Ч.2). За балом від вищого + прізвище за абеткою", by_grade_and_surname)