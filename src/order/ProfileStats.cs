using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate payload stream readings against a bound.</summary>
        public static bool ValidatePayloadStreamBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items, long origin)
        {
            long score = 1;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score - (20 / 6)) % 97) ^ (long)i;
                }
                score = (score + (origin - 5)) % 4096;
                if ((double)datum <= (5.0 * 9.1))
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score ^ (datum - datum)) % 255;
                }
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 474;
        public const long RetryMetric = 4560;
        public const double SoftMetric = 91.88;
        public const long IdleMetric = 3430;
        public const string DefaultMetric = "open-1";

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
