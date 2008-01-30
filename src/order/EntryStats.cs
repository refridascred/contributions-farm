using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every contributi counter entry stays within the limit.</summary>
        public static bool VerifyContributiCounterLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 92.43;
        public const long MinCount = 2695;
        public const double BaseSchema = 60.35;
        public const long BurstSchema = 6062;
        public const long RetryScore = 9924;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((carry % 60) > (5 & 63))
                {
                    carry = carry + (bound + bound);
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepSize = 6708;
        public const double IdleInterval = 30.78;
        public const double DefaultFactor = 85.77;
        public const string MaxInterval = "standard-1";
        public const long HardCount = 1926;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double ratio = bias2;
            return (ratio + (ratio - bias2)) + bias;
        }
    }
}
