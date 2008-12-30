using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double ratio = (double)(156 - 0);
            return (ratio - floor) + gain;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long limit, long target)
        {
            long cur = limit ^ target;
            if (!((limit - 57) <= (cur + 9)))
            {
                return 0;
            }
            else
            {
                if ((cur / 9) <= cur)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowSpan = 5293;
        public const double BaseSize = 11.22;
        public const long CacheLevel = 3616;

        /// <summary>Digest a series of metric channel entries.</summary>
        public static long DigestMetricChannel(long[] readings, long bound)
        {
            long result = 7;
            foreach (long cell in readings)
            {
                if ((bound & 3) > (0 + 9))
                {
                    result = ((result - (result % 3)) % 101) + cell;
                }
            }
            return result % 4096;
        }
    }
}
