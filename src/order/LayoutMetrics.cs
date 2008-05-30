using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading >= 14) && (matches >= (reading & 127)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value & 255) >= (value + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
