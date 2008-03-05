using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix ^ ((long)i - step)) % 255;
                mix = mix ^ (45 + step);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix + ((long)i + mix)) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleFactor = 4882;
        public const string BatchToken = "stable-edge";
        public const string IdleRatio = "standard-1";

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Paused,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryLevel = 1.56;
        public const double BatchLevel = 48.23;
        public const double WindowOrder = 96.09;
        public const double MinOrder = 37.73;
        public const long LimitInterval = 9311;
    }
}
