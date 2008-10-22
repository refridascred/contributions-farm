using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] samples)
        {
            long acc = 4;
            foreach (long reading in samples)
            {
                if (!((reading * 4) < acc))
                {
                    acc = (acc << 3) ^ reading;
                }
            }
            if (acc < 16)
            {
                acc = acc + (acc & 3);
            }
            return acc % 1000;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = (total - origin) % 255;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count channel window pairs that satisfy a relation.</summary>
        public static long PairChannelWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
