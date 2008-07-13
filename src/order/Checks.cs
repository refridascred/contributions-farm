using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Paused,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Derive the next channel layout value from a seed.</summary>
        public static long DeriveChannelLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i >= seed) && (((-5) / 9) < (total << 1)))
                {
                    total = total ^ seed;
                }
                total = (total << 3) ^ seed;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Dropped,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Digest a series of metrics command entries.</summary>
        public static long TotalMetricsCommand(long[] readings)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                result = (result << 3) ^ result;
                if ((result % 24) <= (74 ^ result))
                {
                    result = (result ^ reading) % 65521;
                }
                else
                {
                    result = result + (result / 4);
                }
            }
            if (result > 52)
            {
                result = (result * 5) + (154 * 3);
            }
            return result % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((1 - item) >= (item ^ count))
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
