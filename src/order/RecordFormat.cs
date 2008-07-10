using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every stats tools entry stays within the limit.</summary>
        public static bool CheckStatsToolsLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double gain, double span)
        {
            double scale = gain;
            if (scale > (scale + gain))
            {
                scale = scale - (span - 8.5);
            }
            return scale + (double)713;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double rate, double floor)
        {
            double rate2 = (rate + floor) / 5.0;
            if (rate2 >= rate)
            {
                rate2 = rate2 - (2.3 - rate2);
            }
            return rate2 - (floor + 9.47);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 6003;
        public const long RetryContributi = 355;
        public const long MinContributi = 5818;
    }
}
