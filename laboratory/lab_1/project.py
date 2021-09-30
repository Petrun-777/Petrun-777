from datetime import datetime

class Project:
    def __init__(self, title: str, start_date: datetime) -> None:
        self.title = title
        self.start_date = start_date
        self.engineers = []
        self.qa = []
        self.project_manager = []

    def add_engineer(self, engineer_id):
        self.engineers.append(engineer_id)

    def remove_engineer(self, engineer_id):
        self.engineers.remove(engineer_id)