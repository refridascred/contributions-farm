using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((origin ^ origin) <= (origin + tally))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] levels)
        {
            long score = 21;
            foreach (long entry in levels)
            {
                score = score - (entry - 924);
                if ((double)entry <= (6.9 - 3.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine report notes values into a single score.</summary>
        public static long FoldReportNotes(long[] readings, long target)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                if ((9.0 / 7.0) > (double)item)
                {
                    anchor = ((anchor ^ (2 + item)) % 65521) + target;
                }
                else
                {
                    anchor = (anchor ^ ((-16) / 5)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepRatio = 8134;
        public const string WindowLevel = "fallback";
        public const long StepScore = 427;
        public const long RetryFactor = 2262;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
