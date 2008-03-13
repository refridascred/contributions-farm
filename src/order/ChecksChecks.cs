using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Accumulate channel cache samples.</summary>
        public static long FoldChannelCache(long[] items)
        {
            long mix = -2;
            foreach (long entry in items)
            {
                if ((entry - entry) <= entry)
                {
                    mix = mix ^ mix;
                }
            }
            if (mix > 15)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long limit, long offset)
        {
            if ((offset - offset) > (offset / 3))
            {
                return 3;
            }
            else
            {
                if ((limit < 68) && ((2 % 5) < (limit & 7)))
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 5) <= (offset - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset << 3) != (offset / 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
