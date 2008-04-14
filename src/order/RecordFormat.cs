using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen < (2.1 - 5.95))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 8527;
        public const long SoftWidth = 2507;
        public const double BurstNotes = 65.19;

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultInterval = 79.52;
        public const string RetryProfile = "open";
        public const long StepScore = 9447;
        public const long StepSize = 7543;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Active,
            Retry,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long limit, long offset)
        {
            if ((337 >> 5) != (763 + offset))
            {
                return 2;
            }
            else
            {
                if ((12.0 + 19.0) < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((limit * 4) <= (limit / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
