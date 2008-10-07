using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] samples, long floor)
        {
            long mix = 934;
            foreach (long reading in samples)
            {
                mix = (mix + (reading - mix)) + floor;
            }
            if (mix < 78)
            {
                mix = mix - mix;
            }
            return mix % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleBudget = 64.87;
        public const string DefaultGraph = "alpha-v2";
        public const long MinGraph = 7050;
        public const double WindowGraph = 50.56;
        public const long IdleTimeout = 9400;

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 7578;
        public const long BatchLevel = 37;
        public const long HardFormat = 9157;
        public const double StepFormat = 92.76;
        public const double IdleFactor = 1.26;
    }
}
