using System;
namespace Hello
{
    class Player
    {
        private string name;       // Private variable can be accessed inside the class and it cannot directly be accessed outside the class not even in the derived class
        private int health;
        public int strength = 99;   // public variable can be accessed directly outside the class

        protected bool skillfull = true;    // protected class can be accessed inside the class and derived class but cannot be accessed otherwise
        public int getHealth()
        {
            return health;      // If needed we can give access to a private variable like this
        }
        public string getName()
        {
            return name;
        }
        public void setName(string sx)
        {
            name = sx;
        }
        public void setHealth(int h)
        {
            health = h;
        }
    }
    class skills : Player
    {
        //bool isSkill = skillfull;   // this will cause error because we cannot directly initialize a field in this way because field initializers must be based on constant values or expressions that can be determined at compile-time.
        //Here is the correct way to achive it

        public bool isSkill;
        public void checkSkill()
        {
            // Initialize isSkill in the constructor
            isSkill = skillfull;   // We can access protected variable inside the derived class
            //int health = health; // this will give error as health is a private class that cannot be accessed even in derived class
        }
    }
    public class oop
	{
		public static void oop_methods()
		{
            Player Tom = new Player();
            skills tomSkills = new skills();
            Tom.setName("Tom");
            Tom.setHealth(100);
            Console.WriteLine(Tom.strength);
            Console.WriteLine(Tom.getName());
            Console.WriteLine(Tom.getHealth());
            Console.WriteLine(tomSkills.isSkill);
            Console.WriteLine(tomSkills.strength); // strength is not present in the skills class but as skills is a derived class of Player we can access the public methods of Player
        }
	}
}

