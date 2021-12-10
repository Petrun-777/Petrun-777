package edu.olehhaliak.patterns.pipeline;

import java.util.ArrayList;
import java.util.List;

public class Pipeline {
    public List<Stage> stages = new ArrayList<>();

    public void run(){
        stages.forEach(Stage::execute);
    }

}