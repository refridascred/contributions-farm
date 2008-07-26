using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches ^ value) <= (matches + value)) && ((4.6 * 3.7) >= (double)value))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum == (double)(long)readings.Length)
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Dropped,
            Retry,
            Queued,
        }
    }
}
