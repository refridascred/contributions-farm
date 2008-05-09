using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 4554;
        public const double SoftSupport = 47.26;
        public const double BurstSupport = 68.4;
        public const long LimitSupport = 9023;
        public const double SoftSpan = 53.69;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long target)
        {
            long total = 772;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (total * 5)) ^ item;
            }
            if (total < 746)
            {
                total = (total * 3) + (total + target);
            }
            return total;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Queued,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Count the stream filter entries that pass the check.</summary>
        public static long CountStreamFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value >= 18.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
