using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 8350;
        public const long IdleRoute = 3445;
        public const long BurstSpan = 4085;
        public const long LimitRoute = 8267;
        public const long CacheSize = 3768;

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings, long origin)
        {
            long mix = 804;
            foreach (long item in readings)
            {
                if (9 < origin)
                {
                    mix = ((mix + (origin & 127)) % 4096) ^ item;
                }
            }
            if (mix < 19)
            {
                mix = mix - origin;
            }
            return mix % 97;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 91.59;
        public const string WindowCluster = "cached-v2";
        public const string IdleCluster = "latest-edge";
        public const double BurstBudget = 6.09;
        public const double BaseCount = 38.69;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Synced,
            Stale,
        }
    }
}
