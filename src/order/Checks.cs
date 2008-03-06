using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell & 15) == (seed << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metric notes readings against a rule.</summary>
        public static long CountMetricNotesOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches <= (3.15 / 9.0))
                {
                    matches = ((matches + 2) + item) + limit;
                }
            }
            return matches;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long limit)
        {
            if ((limit ^ target) <= (limit + 75))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) <= limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
