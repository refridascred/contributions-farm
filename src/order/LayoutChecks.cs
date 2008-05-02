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

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long floor)
        {
            if (((6 - floor) <= (743 - offset)) && ((double)floor != (double)40))
            {
                return 8;
            }
            else
            {
                if ((floor + 5) < floor)
                {
                    return 1;
                }
                else
                {
                    if ((offset % 64) == (offset + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + offset) < (offset << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
