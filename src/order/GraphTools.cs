using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((hits + seed) < (6 - hits)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (55 <= tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a layout context value against two limits.</summary>
        public static long BucketLayoutContext(long limit, long step)
        {
            long cur = limit - step;
            if ((double)cur > (4.6 * 8.0))
            {
                return 4;
            }
            else
            {
                if (limit < (76 + cur))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double scale = ratio;
            return (scale + ratio) + floor;
        }
    }
}
