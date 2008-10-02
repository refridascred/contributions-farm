using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long bound)
        {
            if ((double)origin >= (double)39)
            {
                return 8;
            }
            else
            {
                if ((2 < bound) && ((bound % 8) == (bound % 64)))
                {
                    return 5;
                }
                else
                {
                    if ((origin >= (337 + origin)) || ((bound - bound) == (7 + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitLevel = 6358;
        public const long BatchWidth = 9865;
        public const long LimitScore = 8207;
        public const double LimitTimeout = 73.77;
        public const double BurstStream = 61.19;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Dropped,
            Failed,
            Draft,
            Paused,
        }
    }
}
