using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many entry channel samples are out of range.</summary>
        public static long MeasureEntryChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + seen) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats buffer value against two limits.</summary>
        public static long GradeStatsBuffer(long origin, long step)
        {
            long slot = origin ^ step;
            if ((double)step <= (double)slot)
            {
                return 8;
            }
            else
            {
                if ((slot ^ 99) == (6 - slot))
                {
                    return 2;
                }
                else
                {
                    if (((origin * 4) <= (slot * 5)) || (slot <= (slot << 1)))
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "open-v2";
        public const long IdleCluster = 1019;
        public const string BatchBudget = "stable-edge";
        public const long RetryCluster = 5642;
        public const long StepCluster = 976;

        /// <summary>Digest a series of counter channel entries.</summary>
        public static long DigestCounterChannel(long[] series, long bound)
        {
            long anchor = 496;
            foreach (long datum in series)
            {
                if (351 <= (datum / 2))
                {
                    anchor = (anchor - (anchor ^ bound)) % 4096;
                }
            }
            return anchor % 97;
        }
    }
}
