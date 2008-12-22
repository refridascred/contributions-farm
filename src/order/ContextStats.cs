using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples)
        {
            long acc = 179;
            foreach (long datum in samples)
            {
                if (((datum + 71) <= (acc + 501)) || ((acc ^ acc) < (acc - datum)))
                {
                    acc = (acc ^ (acc + datum)) % 4096;
                }
                acc = (acc + (datum * 4)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long target, long floor)
        {
            if (262 >= (floor ^ floor))
            {
                return 7;
            }
            else
            {
                if ((18.0 * 13.0) > (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((target - target) > (537 + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
