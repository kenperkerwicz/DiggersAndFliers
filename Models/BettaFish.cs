using System;

namespace DiggersAndFliers {
public class BettaFish :  ISwim
{
  public string Species {get; set;}

  public string Size {get; set;}


 public void swim() {

 }

    public override string ToString() {
       return "Betta Fish";
    }

}
}