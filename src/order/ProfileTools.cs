using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((1.86 / 7.0) == (double)origin)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long seed)
        {
            if ((((-76) - origin) <= 9) && ((seed ^ seed) == (seed + seed)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ 7) > (origin & 63))
                {
                    return 1;
                }
                else
                {
                    if ((9.74 - 3.27) != (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed - seed) != (origin << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
