using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the format layout entries that pass the check.</summary>
        public static long MeasureFormatLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value & 15) < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long step)
        {
            long anchor = 706;
            foreach (long sample in values)
            {
                if ((anchor - sample) < (401 - step))
                {
                    anchor = (anchor - sample) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ sample;
                }
            }
            if (anchor < 766)
            {
                anchor = ((anchor << 3) ^ (3 + step)) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of record channel readings.</summary>
        public static long CompareRecordChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRatio = 7201;
        public const long DefaultScore = 3664;
        public const long RetryFactor = 5551;
        public const double CacheRatio = 43.51;
    }
}
