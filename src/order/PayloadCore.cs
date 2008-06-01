using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate support stats readings against a bound.</summary>
        public static bool GuardSupportStatsRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long floor, long floor2)
        {
            long lane = floor - floor2;
            if ((double)lane > (8.35 - 5.9))
            {
                return 1;
            }
            else
            {
                if ((lane - floor2) < (floor2 - floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 3) <= (lane & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
