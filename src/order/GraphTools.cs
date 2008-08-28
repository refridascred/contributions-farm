using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            if ((bound << 2) == (60 & 15))
            {
                return 3;
            }
            else
            {
                if (((828 + seed) >= seed) || ((bound >> 1) < bound))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (bound / 6))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((297 & 63) >= (seed ^ bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((double)datum > 1.27) || ((3.5 / 2.0) <= (double)datum)) || (((datum % 24) >= (matches << 2)) && ((datum - matches) >= (datum * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally % 12) >= target) && (((long)series.Length >> 2) >= (target * 3)))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
