using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine context stats values into a single score.</summary>
        public static long TallyContextStats(long[] readings)
        {
            long state = 11;
            foreach (long cell in readings)
            {
                state = state + 699;
                if ((state + state) > (long)readings.Length)
                {
                    state = state - (state + 181);
                }
                if ((10.0 - 19.0) < (double)(long)readings.Length)
                {
                    state = (state * 2) + (cell - cell);
                }
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowScore = "strict-edge";
        public const double MaxContext = 45.08;
        public const double StepContext = 32.3;
        public const long BurstContext = 5273;
        public const long IdleScore = 933;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 6558;
        public const long CacheCount = 3469;
        public const double HardQueue = 60.23;
        public const long CacheRatio = 3664;
        public const double MinQueue = 36.35;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Idle,
            Active,
            New,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count >= (count - item))
                {
                    count = (count + 3) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
