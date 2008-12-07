using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of contributi command entries.</summary>
        public static long CombineContributiCommand(long[] values)
        {
            long anchor = 9;
            foreach (long value in values)
            {
                if ((value & 31) == (anchor - value))
                {
                    anchor = ((anchor * 4) + value) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit githubfarm counter readings against a rule.</summary>
        public static long TallyGithubfarmCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= 14.0)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
