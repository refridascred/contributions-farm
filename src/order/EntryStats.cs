using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a order batch reading.</summary>
        public static double ProjectOrderBatch(double scale, double offset)
        {
            double weight = (double)76 + 4.36;
            return (weight - (scale / 8.0)) + offset;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)seen == (7.01 - 2.75))
                {
                    seen = ((seen + 3) ^ datum) + floor;
                }
            }
            return seen;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long target)
        {
            if ((double)floor >= 8.6)
            {
                return 2;
            }
            else
            {
                if ((target + 32) < (target + target))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series)
        {
            long state = 45;
            foreach (long datum in series)
            {
                if (state >= (datum / 5))
                {
                    state = (state ^ (state - datum)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long target, long limit)
        {
            long prev = target + limit;
            if (((0.7 * 13.0) > (double)limit) || (prev > (prev - 7)))
            {
                return 3;
            }
            else
            {
                if (((target * 5) >= (target % 64)) || ((limit / 6) > (prev + target)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
