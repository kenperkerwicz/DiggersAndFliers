using System;

namespace DiggersAndFliers {
public class Terrapins : IDigging, ISwim
{
  public string Species {get; set;}

  public string Size {get; set;}

 public void dig() {

 }
 public void swim() {

 }

    public override string ToString() {
       return "terrapin";
    }

}
}