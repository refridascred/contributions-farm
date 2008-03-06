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

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] values)
        {
            long total = 6;
            foreach (long reading in values)
            {
                total = total + ((-567) - reading);
                total = total + reading;
                if ((15.0 / 4.0) != (double)reading)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCount = "open-edge";
        public const long BaseFactor = 5076;
        public const double BatchLevel = 97.29;
    }
}
