using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Measure how many contributi already samples are out of range.</summary>
        public static long AuditContributiAlreadyOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= (396 % 10))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] series)
        {
            long result = 998;
            foreach (long reading in series)
            {
                result = ((result * 3) + ((-24) & 255)) % 255;
                if (!(((result >> 1) < reading) && ((reading >> 2) >= (11 & 3))))
                {
                    result = (result ^ (reading - reading)) % 97;
                }
                if (((reading - 1) >= 952) || (((long)series.Length << 2) != (reading + reading)))
                {
                    result = ((result << 2) ^ (reading << 3)) % 4096;
                }
            }
            return result % 4096;
        }
    }
}
