using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] items, long offset)
        {
            long mark = 36;
            foreach (long cell in items)
            {
                if (!((double)cell != (2.2 * 1.5)))
                {
                    mark = (mark - mark) % 4096;
                }
                mark = (mark << 2) ^ (offset - mark);
            }
            if (mark > 94)
            {
                mark = mark + (offset + offset);
            }
            return mark;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((limit > matches) && ((4.1 < (double)cell) || ((2.0 * 0.3) == (double)matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double span)
        {
            double load = (double)(66 & 255);
            if (load >= (double)7)
            {
                load = (load + gain) - span;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
