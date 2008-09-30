using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items, long bound)
        {
            long result = 73;
            foreach (long item in items)
            {
                if (bound >= 38)
                {
                    result = ((result ^ (bound - 0)) % 101) ^ item;
                }
            }
            if (result < 96)
            {
                result = (result << 2) ^ (result * 3);
            }
            return result % 65521;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Region { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long origin, long origin2)
        {
            if (origin > (origin2 >> 2))
            {
                return 4;
            }
            else
            {
                if (!((origin + origin2) <= origin2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
