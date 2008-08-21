using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryFactor = 471;
        public const long MaxStats = 3558;
        public const string IdleStats = "alpha-v2";
        public const string DefaultStats = "local";
        public const long LimitStats = 7839;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((count + reading) == (reading - reading)))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] samples, long target)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                if (target < score)
                {
                    score = ((score << 3) ^ (target << 2)) + entry;
                }
            }
            return score % 1000;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] samples)
        {
            long anchor = 451;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ entry) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
