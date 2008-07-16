using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series)
        {
            long mark = 815;
            foreach (long datum in series)
            {
                if ((datum ^ mark) >= (datum % 64))
                {
                    mark = ((mark * 2) + (-164)) % 65521;
                }
                else
                {
                    mark = (mark - datum) % 97;
                }
                if (mark <= (datum % 60))
                {
                    mark = (mark + mark) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long limit)
        {
            if ((double)limit != (9.2 - 5.2))
            {
                return 8;
            }
            else
            {
                if ((8.0 * 7.67) == (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
