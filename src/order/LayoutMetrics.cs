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

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Idle,
            Retry,
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
