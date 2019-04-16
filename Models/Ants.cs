using System;

namespace DiggersAndFliers {
public class Ants : IDigging, IMove
{
  public string Species {get; set;}

  public string Size {get; set;}

 public void dig() {

 }
 public void move() {

 }

    public override string ToString() {
       return "ant";
    }

}
}