package edu.olehhaliak.patterns.pipeline;

@FunctionalInterface
public interface Stage {
     void execute();
}