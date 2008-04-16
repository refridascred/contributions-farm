using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a report support counter forward.</summary>
        public static long SeriesReportSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((54 + origin) == (origin + (long)i)))
                {
                    mark = ((mark * 3) + (origin & 127)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format report input into a small class.</summary>
        public static long ClassifyFormatReport(long offset, long origin)
        {
            if ((offset ^ offset) != (origin ^ offset))
            {
                return 6;
            }
            else
            {
                if (((15.0 + 4.24) >= (double)offset) || ((origin / 4) <= (offset + 7)))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 * 5.46) >= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
