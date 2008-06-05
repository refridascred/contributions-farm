using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate already metric samples.</summary>
        public static long FoldAlreadyMetric(long[] series, long floor)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                if (!(acc <= (acc & 127)))
                {
                    acc = (((acc * 4) + (sample + sample)) % 1000) - floor;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Pending,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Measure how many queue profile samples are out of range.</summary>
        public static long TallyQueueProfileGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((bound + item) <= (item % 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] samples, long bound)
        {
            long mix = -560;
            foreach (long datum in samples)
            {
                mix = ((mix - (bound / 7)) % 255) ^ datum;
            }
            if (mix > 275)
            {
                mix = (mix - 679) % 97;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryInterval = 9252;
        public const string WindowFactor = "alpha-1";
        public const string SoftSpan = "latest";

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((target % 3) > (target - 957)) && ((target + 109) > count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
