using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((reading >> 2) >= ((-349) >> 5)) || (((long)values.Length >> 3) < (reading + 66))) || (((long)values.Length - reading) > seen))
                {
                    seen = (seen + 2) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            New,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCount = "open-edge";
        public const long BaseFactor = 5076;
        public const double BatchLevel = 97.29;
    }
}
