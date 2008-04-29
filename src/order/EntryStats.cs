using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Check that every payload schema entry stays within the limit.</summary>
        public static bool GuardPayloadSchemaLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftScore = 2.45;
        public const long StepSpan = 9993;
        public const long WindowInterval = 4157;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Audit filter format readings against a rule.</summary>
        public static long MeasureFilterFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (1.7 >= (double)tally)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
