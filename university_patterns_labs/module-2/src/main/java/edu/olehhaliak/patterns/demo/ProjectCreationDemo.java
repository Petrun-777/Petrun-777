package edu.olehhaliak.patterns.demo;

import edu.olehhaliak.patterns.pipeline.AgilePipeline;
import edu.olehhaliak.patterns.pipeline.Pipeline;
import edu.olehhaliak.patterns.project.Module;
import edu.olehhaliak.patterns.project.Project;
import edu.olehhaliak.patterns.team.AgileTeam;

import java.util.List;

public class ProjectCreationDemo {
    public static void main(String[] args) {
        Pipeline agilePipeline = new AgilePipeline();
        AgileTeam teamTitan = new AgileTeam("Titan");
        AgileTeam teamJupiter = new AgileTeam("Jupiter");

        Module module = new Module(Module.ModuleType.ANDROID_APP, "Magnificent android app", teamJupiter, agilePipeline);
        Module module2 = new Module(Module.ModuleType.DB, "Magnificent super DATABASE",teamTitan, agilePipeline);
        Module module3 = new Module(Module.ModuleType.WEB_APP, "Magnificent WEB APP", teamTitan, agilePipeline);
        Project project = new Project("Magnificent inc. platform", List.of(module,module2,module3), 99_999);
        project.build();
    }
}
