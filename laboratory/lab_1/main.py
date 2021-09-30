from employyes import Developer
from project import Project
from datetime import datetime

if __name__ == '__main__':
    developer = Developer(id_=1,first_name='test_name',last_name='test_surname',address='test_address',position='junior',rank='0.7',phone='111111',email='test@test.test')
    project = Project(title='test',start_date=datetime.now())
    developer.assign(project=project)