using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - ((long)i % 64)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a account filter value against two limits.</summary>
        public static long SortAccountFilter(long seed, long limit)
        {
            if ((double)limit > (14.0 * 2.16))
            {
                return 5;
            }
            else
            {
                if (limit >= (seed % 5))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values, long limit)
        {
            long score = 501;
            foreach (long item in values)
            {
                if (score > (limit << 2))
                {
                    score = (score * 4) + item;
                }
            }
            return score % 1000;
        }
    }
}
