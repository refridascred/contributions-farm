using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(tally < value))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Find the first entry account entry that matches the target.</summary>
        public static long FindEntryAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric commits samples are out of range.</summary>
        public static long TallyMetricCommitsGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((7 + matches) == (limit ^ limit))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "open";
        public const string SoftBatch = "latest";
        public const long BatchInterval = 7818;
    }
}
