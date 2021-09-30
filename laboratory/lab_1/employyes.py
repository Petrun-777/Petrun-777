from assignment import Assignment
from project import Project

class Developer:
    def __init__(self, id_: int, first_name: str, last_name: str, address: str, phone: str, email: str, position: str, rank: str) -> None:
        self.id = id_
        self.first_name = first_name
        self.last_name = last_name
        self. address = address
        self.phone = phone
        self.email = email
        self.position = position
        self.rank = rank
        self.assigments = {}

    def get_assigments(self, assigment_id: int) -> Assignment:
        return self.assigments[assigment_id]

    def assign(self, project: Project) -> None:
        project.engineers.append(self)
        assignment = Assignment(title=project.title,project=project)
        self.assignments.append(assignment)
        print(f"Assignment for {self.last_name} to project {project.title} has been created.")

    def inassign(self, project_title: str) -> None:
        idx = -1
        for i, assignment in enumerate(self.assignments):
            if assignment.project.title == project_title:
                idx = i
                break
            if idx != -1:
                del self.assignments[idx]