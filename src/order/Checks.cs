using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((3.0 / 2.0) < (double)offset)
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record context entries.</summary>
        public static long TallyRecordContext(long[] readings, long offset)
        {
            long mix = 6;
            foreach (long reading in readings)
            {
                mix = (mix << 3) ^ (reading + offset);
            }
            if (mix > 3)
            {
                mix = mix - (62 * 5);
            }
            return mix;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowScore = 2273;
        public const string BurstRatio = "fallback-edge";
        public const string IdleChecks = "primary";
        public const long BaseSpan = 5878;
        public const long IdleSpan = 7078;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value >> 4) < value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
