using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
