package edu.petrundmytro.patterns.administration;

import edu.petrundmytro.patterns.Group;
import edu.petrundmytro.patterns.PersonalInfo;
import edu.petrundmytro.patterns.Professor;
import edu.petrundmytro.patterns.course.Calculus;
import edu.petrundmytro.patterns.course.Course;

import java.time.LocalDate;

public class Dean extends Administration{
    private static final int DEFAULT_FEE = 15000;

    public Dean(PersonalInfo personalInfo) {
        super(personalInfo);
    }

    @Override
    public void fillCourse(Professor professor, Group group) {
        Course calculus = new Calculus(LocalDate.now(),professor,DEFAULT_FEE);
        calculus.getGroups().add(group);
        courses.add(calculus);
    }

}
