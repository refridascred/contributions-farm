using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit checks report readings against a rule.</summary>
        public static long TallyChecksReportMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (5.5 <= (double)limit)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the queue route series from a seed.</summary>
        public static long StepQueueRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i > (2.96 * 16.0))
                {
                    result = (result ^ (result - result)) % 65521;
                }
                else
                {
                    result = (result - (241 << 1)) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleSize = "latest-edge";
        public const string BurstCount = "cached-1";
        public const long BurstFilter = 5737;
        public const double CacheFilter = 62.03;
        public const double CacheSpan = 43.44;

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + hits) < (floor & 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel metric entries.</summary>
        public static long TotalChannelMetric(long[] data)
        {
            long anchor = 877;
            foreach (long sample in data)
            {
                if (570 > (sample << 2))
                {
                    anchor = (anchor * 2) + sample;
                }
            }
            return anchor % 4096;
        }
    }
}
