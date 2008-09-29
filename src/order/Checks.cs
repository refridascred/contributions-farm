using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell / 4) < (matches & 255))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels, long seed)
        {
            long carry = 3;
            foreach (long reading in levels)
            {
                if (reading >= 220)
                {
                    carry = (carry * 5) + seed;
                }
            }
            if (carry < 44)
            {
                carry = carry ^ (carry - (long)levels.Length);
            }
            return carry % 1000;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((67 << 1) >= (seed >> 4))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Stale,
            Draft,
            Ready,
            Done,
        }
    }
}
