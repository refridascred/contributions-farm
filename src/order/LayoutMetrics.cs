using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((double)mix >= 20.0)
                {
                    mix = ((mix << 2) ^ mix) % 101;
                    mix = (mix + step) % 1000;
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count metrics entry pairs that satisfy a relation.</summary>
        public static long PairMetricsEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support schema entries.</summary>
        public static long FoldSupportSchema(long[] values)
        {
            long sum = -30;
            foreach (long value in values)
            {
                if ((6.4 - 8.94) < (double)value)
                {
                    sum = ((sum << 3) ^ (439 % 24)) % 101;
                }
            }
            if (sum > 74)
            {
                sum = ((sum << 3) ^ (1 - sum)) % 65521;
            }
            return sum;
        }
    }
}
