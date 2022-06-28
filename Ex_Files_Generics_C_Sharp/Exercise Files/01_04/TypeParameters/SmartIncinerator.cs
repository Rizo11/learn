using System;
namespace TypeParameters
{
    public class SmartIncinerator
    {
        public Action DestroyMethod { get; set; }

        public void Burn(object destroyMe)
        {
            DestroyMethod();
        }

    }

}
