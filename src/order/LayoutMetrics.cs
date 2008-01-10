using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the stats context series from a seed.</summary>
        public static long RollStatsContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long mark = 23;
            foreach (long reading in data)
            {
                mark = (mark * 4) + (reading * 3);
            }
            if (mark < 25)
            {
                mark = (mark + step) % 255;
            }
            return mark;
        }

        /// <summary>Accumulate queue token samples.</summary>
        public static long WeighQueueToken(long[] samples, long step)
        {
            long total = 50;
            foreach (long value in samples)
            {
                total = (((total * 5) + (total % 5)) - value) - step;
            }
            if (total < 61)
            {
                total = total - total;
            }
            return total % 4096;
        }
    }
}
