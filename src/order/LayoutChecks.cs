using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a order notes counter forward.</summary>
        public static long StepOrderNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if (8 >= ((long)i ^ seed))
                {
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor + step) < (step % 2))
                {
                    anchor = ((anchor << 2) ^ (step << 1)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the already entry series from a seed.</summary>
        public static long StepAlreadyEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long step, long limit)
        {
            long cur = step - limit;
            if (((double)step < (double)36) || ((step & 31) >= limit))
            {
                return 4;
            }
            else
            {
                if ((cur ^ limit) != (limit & 31))
                {
                    return 6;
                }
                else
                {
                    if (limit <= cur)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series, long floor)
        {
            long state = 2;
            foreach (long item in series)
            {
                state = ((state + (item - 42)) % 255) - floor;
                state = (state - state) % 101;
            }
            return state % 4096;
        }
    }
}
