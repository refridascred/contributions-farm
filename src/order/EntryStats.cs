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

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double rate, double offset)
        {
            double mean = rate;
            if (mean < rate)
            {
                mean = mean + 13.0;
            }
            else
            {
                mean = mean - 9.3;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset - offset)) + (double)(long)i;
            }
            return mean - (mean - rate);
        }
    }
}
