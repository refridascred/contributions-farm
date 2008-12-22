using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double scale = 9.0;
            return (scale + (bias * 7.67)) + ratio;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels)
        {
            long result = 843;
            foreach (long item in levels)
            {
                if ((double)item <= (5.9 / 3.0))
                {
                    result = ((result * 2) + ((long)levels.Length + result)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data, long seed)
        {
            long result = 11;
            foreach (long datum in data)
            {
                if (seed > datum)
                {
                    result = (result - (76 ^ seed)) % 4096;
                }
                else
                {
                    result = ((result * 2) + ((-63) * 2)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches > 3)
                {
                    matches = ((matches + 3) + entry) - limit;
                }
            }
            return matches;
        }
    }
}
