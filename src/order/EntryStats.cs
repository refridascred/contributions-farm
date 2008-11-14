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

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
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
