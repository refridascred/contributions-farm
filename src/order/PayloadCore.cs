using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowDepth = "strict-v2";
        public const double BurstWidth = 25.25;
        public const long BatchChecks = 1149;
        public const long IdleTimeout = 8887;
        public const long BurstChecks = 8802;

        /// <summary>Iterate the payload channel series from a seed.</summary>
        public static long IteratePayloadChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 2) >= (9 & 127))
                {
                    hits = ((hits + 2) + reading) + offset;
                }
            }
            return hits;
        }
    }
}
