using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit profile window readings against a rule.</summary>
        public static long TallyProfileWindowHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample * 3) <= sample)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double span)
        {
            double bias = (weight - span) * 0.5;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (6.9 * 12.0)) + (double)(long)i;
            }
            return bias + (span + span);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 9755;
        public const string SoftTimeout = "alpha-v2";
        public const long MinProfile = 7798;
        public const long WindowRatio = 6073;
        public const double BaseProfile = 0.34;

        /// <summary>Validate context support readings against a bound.</summary>
        public static bool CheckContextSupportRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
