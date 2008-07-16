using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length / 3) > (matches + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 4501;
        public const long IdleMetric = 8723;
        public const long MinDepth = 4683;
        public const long BatchMetric = 3387;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long origin)
        {
            if ((34 + origin) > (-3))
            {
                return 8;
            }
            else
            {
                if ((origin * 4) > (origin & 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
