using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank profile route input into a small class.</summary>
        public static long SortProfileRoute(long limit, long target)
        {
            if ((3.0 * 1.0) >= (double)target)
            {
                return 5;
            }
            else
            {
                if (!((6.39 + 17.0) >= (double)target))
                {
                    return 6;
                }
                else
                {
                    if ((limit % 5) <= (limit & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(835 >= limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
