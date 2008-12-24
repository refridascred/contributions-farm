using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every support notes entry stays within the limit.</summary>
        public static bool VerifySupportNotesLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstRatio = 4755;
        public const long DefaultFarm = 3089;
        public const long IdleDepth = 2656;
        public const double LimitBudget = 11.66;
        public const double LimitSpan = 69.55;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum < (seen - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item * 5) <= (bound + (-71))) || ((9.0 / 7.0) <= (double)bound))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
