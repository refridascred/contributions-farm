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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long seed)
        {
            if (((94 ^ offset) > (225 / 8)) && ((double)offset != (4.0 * 9.88)))
            {
                return 1;
            }
            else
            {
                if ((seed << 1) <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ offset) < (seed & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((72 * 5) > seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
