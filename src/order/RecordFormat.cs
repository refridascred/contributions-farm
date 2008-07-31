using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long offset, long floor)
        {
            long offset2 = offset - floor;
            if ((5.6 + 5.4) == (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor >> 5) < offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset2 & 31) < offset2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 5) < (offset + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if (seed <= (seed + origin))
            {
                return 6;
            }
            else
            {
                if ((1.6 / 4.0) < (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((origin - seed) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
