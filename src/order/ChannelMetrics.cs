using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long offset)
        {
            if (floor >= (floor + offset))
            {
                return 1;
            }
            else
            {
                if (((floor & 255) < (3 - offset)) || (offset > (offset * 5)))
                {
                    return 6;
                }
                else
                {
                    if ((2.5 - 11.0) > (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor > (6.36 - 20.0))
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

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long anchor = 413;
            foreach (long value in levels)
            {
                if ((value + (-5)) >= (value - 2))
                {
                    anchor = ((anchor * 4) + (6 >> 2)) % 255;
                }
            }
            if (anchor < 16)
            {
                anchor = anchor + ((-63) + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Closed,
            Pending,
            Synced,
        }
    }
}
