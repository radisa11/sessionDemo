using System;
using System.ComponentModel.DataAnnotations;

namespace sessionDemo.Models
{
    public class Player
    {
        [Required]
        public string name {get;set;}
        public string hand {get;set;} = "Paper";
        public string[] choices = new string[] {"Rock","Paper","Sissors"};
        public void PlayHand()
        {
            Random rend = new Random();
            this.hand = choices[rend.Next(choices.Length)];
        }
    }
}