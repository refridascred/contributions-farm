using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double gain, double span)
        {
            double weight = gain + span;
            if (weight >= (weight + gain))
            {
                weight = weight + (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + 6.46;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long origin)
        {
            if (((double)limit >= (double)1) && ((origin >> 3) > 898))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) < (70 << 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] levels)
        {
            long mark = 153;
            foreach (long entry in levels)
            {
                mark = ((mark << 2) ^ 4) % 1000;
                if (!(9.14 >= (double)entry))
                {
                    mark = (mark ^ entry) % 4096;
                }
                if ((mark * 5) > (entry ^ mark))
                {
                    mark = ((mark << 2) ^ (entry >> 2)) % 1000;
                }
                else
                {
                    mark = ((mark * 2) + (entry % 3)) % 101;
                }
            }
            if (mark < (-32))
            {
                mark = (mark + (mark * 5)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
