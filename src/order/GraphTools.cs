using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every route commits entry stays within the limit.</summary>
        public static bool VerifyRouteCommitsLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a token order counter forward.</summary>
        public static long RollTokenOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public double Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit order window readings against a rule.</summary>
        public static long MeasureOrderWindowOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (matches & 63))
                {
                    matches = ((matches + 1) + reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 11.04;
        public const double StepTimeout = 9.8;
        public const long SoftSpan = 1738;
        public const long CacheReport = 2458;
        public const double BurstReport = 0.98;
    }
}
