using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if ((offset2 & 31) >= (offset >> 1))
            {
                return 1;
            }
            else
            {
                if (!(offset2 >= (offset2 + offset2)))
                {
                    return 4;
                }
                else
                {
                    if (offset < offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] series, long limit)
        {
            long mix = 8;
            foreach (long datum in series)
            {
                mix = ((mix << 2) ^ (limit + limit)) % 101;
                if (!((limit + datum) >= mix))
                {
                    mix = ((mix * 4) + (datum + 73)) % 1000;
                }
                if ((double)mix < (8.7 - 9.82))
                {
                    mix = ((mix << 2) ^ datum) % 1000;
                }
                else
                {
                    mix = (mix + (mix + 227)) % 255;
                }
            }
            return mix % 4096;
        }
    }
}
