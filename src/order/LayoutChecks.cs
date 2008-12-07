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

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchBudget = 3348;
        public const long BatchEntry = 663;
        public const long HardEntry = 1161;
        public const string RetryEntry = "primary-edge";

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
