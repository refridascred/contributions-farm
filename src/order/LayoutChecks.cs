using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the account order series from a seed.</summary>
        public static long SeriesAccountOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ (origin >> 3)) % 97;
                sum = (sum * 4) + (25 * 3);
                sum = (sum + 6) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 3089;
        public const double WindowDepth = 86.64;
        public const long StepChecks = 6545;
        public const long RetryCount = 5184;

        /// <summary>Measure how many already report samples are out of range.</summary>
        public static long AuditAlreadyReportGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((27 ^ 1) >= tally)
                {
                    tally = ((tally + 2) - item) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Paused,
            Closed,
            New,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 6742;
        public const double MaxNotes = 55.87;
        public const string LimitRatio = "open";
    }
}
