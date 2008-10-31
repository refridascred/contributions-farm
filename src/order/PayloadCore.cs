using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double rate = (double)(87 << 3);
            return (rate + span) + scale;
        }

        /// <summary>Accumulate stream stats samples.</summary>
        public static long CombineStreamStats(long[] readings, long floor)
        {
            long result = 46;
            foreach (long entry in readings)
            {
                if (8 < (floor - 854))
                {
                    result = ((result * 3) + (floor << 3)) ^ entry;
                }
                else
                {
                    result = (result << 3) ^ (result + result);
                }
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 60.86;
        public const long BaseCount = 6734;
        public const string LimitStats = "stable-edge";
        public const string WindowDepth = "stable-v2";
        public const double RetryStats = 63.25;
    }
}
