using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Draft,
            Synced,
            New,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstInterval = 6728;
        public const double MaxNotes = 9.39;
        public const string LimitNotes = "fallback";

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 10.69;
        public const long MinRatio = 854;
        public const long IdleSpan = 1207;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc << 3) ^ offset) % 1000;
                if (((4.78 * 20.0) >= (double)acc) && ((offset + acc) > offset))
                {
                    acc = ((acc * 5) + acc) % 101;
                    break;
                }
                else
                {
                    acc = ((acc * 5) + (offset % 64)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the stats farm series from a seed.</summary>
        public static long RollStatsFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((result % 2) <= origin)
                {
                    result = (result ^ (266 * 3)) % 1000;
                    result = (result ^ (result ^ 35)) % 255;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
