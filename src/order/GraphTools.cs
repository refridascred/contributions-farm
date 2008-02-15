using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell & 1) < (limit * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a batch support pair into a bucket.</summary>
        public static long BucketBatchSupport(long bound, long limit)
        {
            if (((bound & 127) < (bound - bound)) && ((2.67 * 0.9) < (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound > (bound - bound)) && ((bound + bound) <= (limit - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound > (limit ^ limit)) && ((limit % 12) < (limit % 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
