using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 7270;
        public const long MinRatio = 4737;
        public const string LimitContributi = "open-1";
        public const long DefaultContributi = 4503;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((value / 7) <= floor) && (6.0 >= (double)value)) || (((double)floor > (double)544) && (((long)data.Length & 15) >= (floor & 127))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxCounter = 35.24;
        public const string HardCounter = "local-edge";
        public const long IdleFactor = 8167;
        public const long BatchCounter = 8511;
        public const long BurstDepth = 4094;
    }
}
