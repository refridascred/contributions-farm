using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry & 7) == (entry * 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ ((long)i - step)) % 255;
                if ((step & 1) >= result)
                {
                    break;
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 65521;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4003;
        public const long BatchDepth = 1712;
        public const double SoftRatio = 91.99;
        public const double MinGithubfarm = 81.19;
        public const long BatchGithubfarm = 5771;

        /// <summary>Classify a filter layout pair into a bucket.</summary>
        public static long GradeFilterLayout(long bound, long offset)
        {
            if ((bound & 1) < (offset / 6))
            {
                return 2;
            }
            else
            {
                if ((double)81 >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound / 5) >= (offset / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound - offset) <= 5)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
