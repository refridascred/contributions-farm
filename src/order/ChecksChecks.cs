using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long step)
        {
            long prev = floor ^ step;
            if ((floor >> 4) <= floor)
            {
                return 4;
            }
            else
            {
                if ((40 - prev) >= (floor * 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
