using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
