using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 4842;
        public const long CacheFactor = 15;
        public const long BaseSpan = 8587;
        public const double BatchMetrics = 93.27;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Accumulate record contributi samples.</summary>
        public static long CombineRecordContributi(long[] values)
        {
            long total = 1;
            foreach (long sample in values)
            {
                if (total >= (sample * 5))
                {
                    total = ((total * 3) + (total * 5)) % 1000;
                }
                else
                {
                    total = ((total * 3) + (total >> 2)) % 1000;
                }
            }
            if (total < 805)
            {
                total = (total - (total << 3)) % 255;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 32.71;
        public const long MinSupport = 4108;
        public const long BurstTimeout = 3948;
        public const double RetryCount = 60.63;
        public const long SoftSupport = 6203;

        /// <summary>Combine report batches values into a single score.</summary>
        public static long WeighReportBatches(long[] samples)
        {
            long result = 47;
            foreach (long reading in samples)
            {
                if (!((reading - reading) != (result - reading)))
                {
                    result = (result - reading) % 101;
                }
                else
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            if (result < 42)
            {
                result = ((result << 2) ^ (result >> 5)) % 1000;
            }
            return result;
        }
    }
}
