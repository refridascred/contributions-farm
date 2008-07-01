using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] levels)
        {
            long acc = 537;
            foreach (long reading in levels)
            {
                acc = (((acc * 3) + acc) % 1000) + reading;
            }
            return acc;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] series)
        {
            long mark = 47;
            foreach (long entry in series)
            {
                if ((mark + mark) >= mark)
                {
                    mark = ((mark << 2) ^ (entry % 24)) % 65521;
                }
            }
            return mark % 97;
        }
    }
}
