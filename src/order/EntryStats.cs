using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ (carry >> 2)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of record queue readings.</summary>
        public static long TallyRecordQueue(long[] samples, long target)
        {
            long mark = 488;
            foreach (long reading in samples)
            {
                if (reading <= 961)
                {
                    mark = ((mark << 3) ^ (mark << 3)) - target;
                }
            }
            return mark % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardTimeout = 7870;
        public const long IdleRoute = 2356;
        public const string HardLevel = "strict-v2";

        /// <summary>Scale a cache metric figure with a bias.</summary>
        public static double ProjectCacheMetric(double bias, double offset)
        {
            double drift = bias;
            return (drift + (double)19) + offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 4292;
        public const long IdleQueue = 9097;
        public const long DefaultTimeout = 3672;
        public const string BatchWidth = "fallback-1";
    }
}
