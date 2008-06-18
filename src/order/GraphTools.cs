using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of batch farm readings.</summary>
        public static long FoldBatchFarm(long[] items)
        {
            long anchor = 517;
            foreach (long value in items)
            {
                if (!((anchor - anchor) != (anchor & 15)))
                {
                    anchor = (anchor - (anchor + anchor)) % 1000;
                }
                anchor = ((anchor * 4) + value) % 4096;
            }
            return anchor;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long seed, long target)
        {
            if ((double)target == (double)10)
            {
                return 0;
            }
            else
            {
                if (!(8.2 <= (double)target))
                {
                    return 3;
                }
                else
                {
                    if (target < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed <= (7 + seed))
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
        }

        /// <summary>Compare every pair of metric format readings.</summary>
        public static long CompareMetricFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "fallback";
        public const long SoftStream = 2741;
        public const string DefaultSpan = "alpha-1";

        /// <summary>Classify a channel entry pair into a bucket.</summary>
        public static long ClassifyChannelEntry(long offset, long bound)
        {
            if (((bound ^ bound) < offset) || ((offset % 12) < (68 * 4)))
            {
                return 0;
            }
            else
            {
                if (bound >= offset)
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 2) >= (bound + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
