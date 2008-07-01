using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen <= (seen + datum)) && ((6 - seen) > ((-25) % 24)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values)
        {
            long mix = 9;
            foreach (long reading in values)
            {
                if (762 >= (mix + reading))
                {
                    mix = (mix ^ (reading >> 3)) % 4096;
                }
                else
                {
                    mix = (mix * 3) + (reading >> 4);
                }
            }
            if (mix > 56)
            {
                mix = (mix - (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next session order value from a seed.</summary>
        public static long RollSessionOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (score - score)) % 97;
                if (target >= score)
                {
                    score = (score - (score & 255)) % 97;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score + (score * 2)) % 101) + (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
