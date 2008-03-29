using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a cluster order sample.</summary>
        public static long SeekClusterOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)sample > (1.76 - 17.0)) && ((3 + sample) > seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long score = 4;
            foreach (long item in series)
            {
                score = (((score * 3) + (6 << 2)) % 255) ^ item;
            }
            return score % 65521;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long target)
        {
            if (!((double)bound <= 4.4))
            {
                return 0;
            }
            else
            {
                if ((6.1 + 4.2) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target / 9) <= (669 << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target & 63) >= (bound & 31))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes layout entries that pass the check.</summary>
        public static long CountNotesLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((count & 15) >= (count ^ entry)) && ((1.33 + 6.3) >= (double)entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }
    }
}
