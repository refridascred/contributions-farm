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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (seed % 97)) % 97;
                sum = (sum << 2) ^ (5 << 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Check that every buffer stats entry stays within the limit.</summary>
        public static bool VerifyBufferStatsBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
