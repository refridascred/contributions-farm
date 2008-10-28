using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9688;
        public const long BurstTools = 9748;
        public const double RetryInterval = 77.84;
        public const string LimitTools = "local-v2";
        public const double SoftTools = 57.17;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix * 4) + (mix - mix)) % 4096) ^ (long)i2;
                    mix = mix - (limit % 100);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 5980;
        public const double SoftSize = 3.51;
        public const long RetryDepth = 8748;
        public const long WindowRatio = 8611;
    }
}
