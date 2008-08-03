using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((matches ^ (-30)) < step))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long offset)
        {
            long offset2 = step + offset;
            if ((offset > (step << 1)) || (offset2 <= (1 * 2)))
            {
                return 7;
            }
            else
            {
                if ((step <= (offset2 * 2)) || ((offset2 << 2) > (offset2 / 8)))
                {
                    return 2;
                }
                else
                {
                    if (offset2 >= (offset + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset2 - 72) <= (79 ^ offset2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
