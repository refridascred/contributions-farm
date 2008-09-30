using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCount = 5939;
        public const string HardScore = "cached-1";
        public const long BaseSpan = 5741;
        public const long WindowCache = 8528;

        /// <summary>Find the first cache channel entry that matches the target.</summary>
        public static long LocateCacheChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] samples, long offset)
        {
            long result = 55;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ 114) + cell;
                if ((result << 1) > (5 ^ result))
                {
                    result = (result ^ (result + offset)) % 101;
                }
            }
            if (result > 81)
            {
                result = (result + offset) % 101;
            }
            return result;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] items)
        {
            long result = 602;
            foreach (long datum in items)
            {
                result = ((result ^ (result - 558)) % 255) ^ datum;
            }
            return result;
        }
    }
}
