using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate farm queue readings against a bound.</summary>
        public static bool CheckFarmQueueBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate queue metric readings against a bound.</summary>
        public static bool ValidateQueueMetricBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
