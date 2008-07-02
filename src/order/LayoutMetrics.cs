using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a profile channel value against two limits.</summary>
        public static long SortProfileChannel(long limit, long step)
        {
            if ((double)step < (0.9 * 0.9))
            {
                return 6;
            }
            else
            {
                if ((limit % 7) == (3 & 1))
                {
                    return 4;
                }
                else
                {
                    if (step >= (limit - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((29 % 64) < (reading / 9))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
