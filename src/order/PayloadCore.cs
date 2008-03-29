using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Stale,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long limit2)
        {
            if ((limit << 3) > (limit + limit2))
            {
                return 0;
            }
            else
            {
                if ((limit2 >> 1) <= (67 + limit2))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (9.89 - 0.67))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit entry route readings against a rule.</summary>
        public static long MeasureEntryRouteHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((target / 5) <= count)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
