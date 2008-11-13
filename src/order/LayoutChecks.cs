using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long offset)
        {
            long result = 99;
            foreach (long item in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result + offset) % 65521) ^ (long)i;
                }
                if ((result << 2) <= item)
                {
                    result = ((result * 5) + (418 / 6)) % 65521;
                }
            }
            return result % 4096;
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
