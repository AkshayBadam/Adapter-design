using System;
namespace sound
{
    public class Adapter : NormalSound
    {
        Dolby obj=new Dolby();
        public void Sound()
        {
            obj.DolbySpeaker();
        }
    }
}
