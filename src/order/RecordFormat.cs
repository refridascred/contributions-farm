using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate batch entry samples.</summary>
        public static long TotalBatchEntry(long[] readings)
        {
            long carry = 82;
            foreach (long datum in readings)
            {
                carry = (carry * 4) + (datum ^ datum);
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftTimeout = 7746;
        public const long IdleQueue = 7332;
        public const long BatchTimeout = 1629;

        /// <summary>Scale a commits queue figure with a bias.</summary>
        public static double SmoothCommitsQueue(double scale, double offset)
        {
            double rate = (scale * 0.6) - (offset * 7.1);
            if (rate > offset)
            {
                rate = rate + (scale - scale);
            }
            else
            {
                rate = rate + rate;
            }
            return rate - scale;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series, long seed)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (sample + result)) - seed;
            }
            return result;
        }
    }
}
