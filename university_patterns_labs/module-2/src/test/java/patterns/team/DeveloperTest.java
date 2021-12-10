package patterns.team;

import edu.olehhaliak.patterns.team.Developer;
import edu.olehhaliak.patterns.technology.JavaScript;
import edu.olehhaliak.patterns.technology.Python;
import org.junit.jupiter.api.Test;

public class DeveloperTest {
    @Test
    void devTest() {
        Developer developer = new Developer("John",new JavaScript(),(D)-> {System.out.println("Typing in hurry,because deadline was yesterday");});
        developer.writeCode();
    }
}
