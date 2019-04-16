using System;

namespace DiggersAndFliers {
public class Earthworms : IDigging
{
  public string Species {get; set;}

  public string Size {get; set;}

 public void dig() {

 }

     public override string ToString() {
       return "earthworm";
    }

}
}