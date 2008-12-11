using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((sample < (matches + matches)) || ((7 >> 3) != (target ^ target))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats editor pair into a bucket.</summary>
        public static long GradeStatsEditor(long floor, long seed)
        {
            if ((floor + floor) < ((-779) << 1))
            {
                return 2;
            }
            else
            {
                if ((880 - seed) == (floor << 3))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long limit2)
        {
            long cur = limit + limit2;
            if ((limit2 - cur) > limit)
            {
                return 7;
            }
            else
            {
                if ((limit <= (55 << 1)) || ((14.0 * 15.0) != (double)cur))
                {
                    return 6;
                }
                else
                {
                    if ((cur + 62) <= (limit - limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)limit < (7.0 - 1.6)) || ((limit + 7) != (limit2 + limit2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
