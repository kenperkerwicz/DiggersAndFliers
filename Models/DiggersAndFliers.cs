using System.Collections.Generic;

namespace DiggersAndFliers

{
  public class DiggersAndFliers
  {



public List<IDigging> DiggingAnimals()
    {
      List<IDigging> DiggingAnimals = new List<IDigging>() {
          new Earthworms(),
          new Finches(),
          new Ants(),
          new Mice(),
      };
      return DiggingAnimals ;
    }

     public List<ISwim> SwimmingAnimals()
    {
      List<ISwim> SwimmingAnimals = new List<ISwim>() {
          new Terrapins(),
          new Terrapins(),
          new BettaFish()
      };
      return SwimmingAnimals ;
    }

  }

}