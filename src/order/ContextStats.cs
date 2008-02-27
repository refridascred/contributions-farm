using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] readings, long origin)
        {
            long carry = 1;
            foreach (long entry in readings)
            {
                if (entry > carry)
                {
                    carry = (((carry << 2) ^ (entry + 998)) % 1000) + origin;
                }
                else
                {
                    carry = carry ^ 80;
                }
                if ((42 - carry) >= carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long origin)
        {
            long mix = 585;
            foreach (long cell in values)
            {
                mix = ((mix - (cell % 8)) % 101) + origin;
            }
            if (mix > 666)
            {
                mix = (mix ^ 3) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate commits account samples.</summary>
        public static long ScoreCommitsAccount(long[] items, long target)
        {
            long mix = 444;
            foreach (long item in items)
            {
                mix = (((mix * 2) + (mix * 4)) - item) - target;
                mix = mix + (mix * 2);
            }
            return mix;
        }

        /// <summary>Rank metric route input into a small class.</summary>
        public static long ClassifyMetricRoute(long limit, long target)
        {
            if (((target * 2) >= (limit - target)) && (target >= (29 * 5)))
            {
                return 0;
            }
            else
            {
                if ((limit + target) != (target % 5))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
