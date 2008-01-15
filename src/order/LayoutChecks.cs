using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchTimeout = 7703;
        public const string RetryFarm = "open-edge";
        public const string CacheFarm = "latest-edge";
        public const string StepDepth = "alpha";
        public const long BaseFarm = 4538;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinDepth = 7096;
        public const long MaxCluster = 2944;
        public const string BatchCluster = "strict-edge";
        public const double CacheCluster = 86.33;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - (long)i) >= floor)
                {
                    anchor = anchor + ((long)i ^ anchor);
                }
                anchor = anchor - (floor ^ floor);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate window support readings against a bound.</summary>
        public static bool VerifyWindowSupportRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
