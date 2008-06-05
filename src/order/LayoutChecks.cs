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

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] series)
        {
            long anchor = 0;
            foreach (long value in series)
            {
                if (!((double)value > (3.5 - 1.4)))
                {
                    anchor = anchor + (anchor ^ value);
                }
                else
                {
                    anchor = (anchor + ((long)series.Length & 15)) % 101;
                }
            }
            if (anchor > (-23))
            {
                anchor = ((anchor * 3) + (anchor ^ anchor)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 22;
        public const long MaxFilter = 3550;
        public const double HardTimeout = 5.86;
        public const long BurstFilter = 1302;
        public const string CacheTimeout = "strict-1";

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
