package edu.olehhaliak.patterns.technology;

public abstract class Technology {
   public final String name;

   public Technology(String name) {
      this.name = name;
   }

   public abstract void doSomeStuff();
}
