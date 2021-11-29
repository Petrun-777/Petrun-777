package edu.petrundmytro.patterns.course;

import edu.petrundmytro.patterns.Professor;

import java.time.LocalDate;

public class DesignPatterns extends DefaultCourseImpl{
    private static final String NAME = "Design patterns";
    public DesignPatterns( LocalDate date, Professor professor, float fee) {
        super(NAME, date, professor, fee);
    }

    public DesignPatterns( LocalDate date, float fee) {
        super(NAME, date, fee);
    }
}
