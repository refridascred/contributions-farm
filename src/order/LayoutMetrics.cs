using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long limit2)
        {
            long prev = limit ^ limit2;
            if ((double)prev >= (14.0 / 3.0))
            {
                return 2;
            }
            else
            {
                if (((limit % 100) < (-63)) || ((double)limit2 >= (6.2 / 9.0)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] series, long target)
        {
            long mix = 7;
            foreach (long cell in series)
            {
                mix = ((mix + (mix - target)) % 97) + cell;
            }
            return mix;
        }
    }
}
