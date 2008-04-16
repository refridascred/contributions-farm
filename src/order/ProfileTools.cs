using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next farm contributi value from a seed.</summary>
        public static long StepFarmContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc * 5) + acc;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
