package edu.petrundmytro.patterns.course;

import edu.petrundmytro.patterns.Professor;

import java.time.LocalDate;

public class MachineLearning extends DefaultCourseImpl{
    private static final String NAME = "Calculus";

    public MachineLearning( LocalDate date, Professor professor, float fee) {
        super(NAME, date, professor, fee);
    }

    public MachineLearning(LocalDate date, float fee) {
        super(NAME, date, fee);
    }
}
