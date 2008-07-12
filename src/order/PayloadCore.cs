using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((acc + floor) != (acc * 4))
                {
                    acc = acc - (floor + acc);
                }
                else
                {
                    acc = (acc ^ (acc ^ floor)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstBudget = "open-1";
        public const long DefaultLayout = 5760;
        public const string StepLayout = "alpha";

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 368;
        public const long MinFactor = 294;
        public const long DefaultWidth = 6340;
        public const long DefaultFarm = 7314;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9626;
        public const long IdleContributi = 3779;
        public const long HardInterval = 1787;
    }
}
