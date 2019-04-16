using System;

namespace DiggersAndFliers {
public class Parakeet : IFlying
{
  public string Species {get; set;}

  public string Size {get; set;}
  
 public void fly() {

 }

     public override string ToString() {
       return "parakeet";
    }

}
}