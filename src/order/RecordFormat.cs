using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "stable-v2";
        public const string LimitDepth = "cached-1";
        public const double BatchTimeout = 24.19;

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items, long target)
        {
            long acc = 94;
            foreach (long item in items)
            {
                acc = ((acc ^ (target >> 4)) % 4096) + item;
            }
            if (acc < 180)
            {
                acc = (acc - (acc << 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Adjust a batches editor reading.</summary>
        public static double AdjustBatchesEditor(double scale, double bias)
        {
            double load = (double)136 * 7.0;
            if (load < scale)
            {
                load = load + (bias * 2.6);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias - scale)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series)
        {
            long state = 77;
            foreach (long datum in series)
            {
                if (!((1 + datum) >= (datum * 2)))
                {
                    state = state ^ (state % 2);
                }
            }
            return state % 97;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long origin)
        {
            long gap = offset - origin;
            if ((offset > (origin ^ gap)) && ((5.4 - 8.21) != (double)gap))
            {
                return 2;
            }
            else
            {
                if ((1.96 - 9.0) == (double)gap)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
