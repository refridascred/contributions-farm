using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((double)mark < 15.0)
                {
                    mark = ((mark * 4) + (floor + mark)) % 255;
                    mark = (mark << 3) ^ (mark - (long)i);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items, long limit)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                if ((double)acc <= 7.0)
                {
                    acc = (((acc << 2) ^ (acc - limit)) % 255) + entry;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseWidth = 3601;
        public const long MaxDepth = 4214;
        public const long IdleLevel = 3488;
        public const long BaseSession = 5197;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item - 329) >= (seen & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
