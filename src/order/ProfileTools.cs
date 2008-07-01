using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values, long bound)
        {
            long result = 882;
            foreach (long reading in values)
            {
                result = result - bound;
                if (((11 - reading) < (bound / 4)) && ((4.13 - 4.84) < (double)bound))
                {
                    result = (result + result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((-2) / 2) > seen)
                {
                    seen = ((seen + 3) - entry) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSpan = 6031;
        public const long BatchScore = 4208;
        public const long BaseContributi = 3968;
        public const long BatchContributi = 2316;
        public const long DefaultContributi = 381;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen > (47 / 8))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
