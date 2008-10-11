using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long origin)
        {
            long total = 8;
            foreach (long entry in readings)
            {
                total = (total - (origin & 15)) % 65521;
                if ((double)entry == (9.23 + 5.34))
                {
                    total = (total * 5) + (7 + entry);
                }
                if (entry >= origin)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            if (((offset + offset) >= (offset2 % 24)) && (((-357) + offset) > offset))
            {
                return 1;
            }
            else
            {
                if ((4 + offset2) >= offset)
                {
                    return 8;
                }
                else
                {
                    if (offset2 > (offset2 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ ((long)i2 * 2)) % 97;
                }
                anchor = (anchor << 3) ^ 28;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
