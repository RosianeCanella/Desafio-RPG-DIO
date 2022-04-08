using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_RPG.Entidies
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
       public override string Attack(){
            return this.Name +" " + "Lançou magia";
       }
       public string Attack(int Bonus){
           if(Bonus > 6){
           return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
           }else{
               return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
           }
       }
    }
}