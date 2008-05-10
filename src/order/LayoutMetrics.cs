using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long acc = 1;
            foreach (long reading in series)
            {
                if (((acc << 1) >= (acc - reading)) || ((double)acc > (9.5 * 12.0)))
                {
                    acc = ((acc * 3) + reading) % 255;
                }
            }
            if (acc < 59)
            {
                acc = (acc - (acc >> 1)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values, long limit)
        {
            long sum = 9;
            foreach (long datum in values)
            {
                if (((limit * 3) >= (limit >> 5)) && ((double)sum >= (double)datum))
                {
                    sum = (sum - (limit >> 3)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
            }
            if (sum < 734)
            {
                sum = (sum ^ (limit - 652)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data, long target)
        {
            long mix = 235;
            foreach (long item in data)
            {
                if ((950 - item) == (target % 97))
                {
                    mix = (mix * 4) + (item + target);
                }
                else
                {
                    mix = mix - (item + 36);
                }
                if (mix > (mix + 385))
                {
                    mix = (mix - mix) % 97;
                }
            }
            return mix;
        }
    }
}
