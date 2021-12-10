package patterns.project;

import edu.olehhaliak.patterns.pipeline.Pipeline;
import edu.olehhaliak.patterns.project.Module;
import edu.olehhaliak.patterns.team.Team;
import org.junit.jupiter.api.Test;

public class ModuleTest {
    @Test
    void moduleBuildTest() {
        Module module = new Module();
        module.name = "Mobile app";
        module.pipeline = new Pipeline();
        module.pipeline.stages.add(()-> System.out.println("building app"));
        module.pipeline.stages.add(()-> System.out.println("testing app"));
        module.pipeline.stages.add(()-> System.out.println("deploying app"));
        module.team = new Team();
        module.team.name = "Jupiter";
        module.type = Module.ModuleType.ANDROID_APP;
        module.build();
    }
}
