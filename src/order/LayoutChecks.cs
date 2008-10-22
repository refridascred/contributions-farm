using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a order batches figure with a bias.</summary>
        public static double ScaleOrderBatches(double bias, double span)
        {
            double weight = (double)8 + span;
            if (weight > span)
            {
                weight = weight - weight;
            }
            return weight + (bias + bias);
        }

        /// <summary>Combine support token values into a single score.</summary>
        public static long WeighSupportToken(long[] values)
        {
            long anchor = 0;
            foreach (long cell in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor + (anchor * 3)) ^ (long)i;
                    anchor = (anchor << 2) ^ 95;
                }
                if ((double)anchor != (double)cell)
                {
                    anchor = (anchor - cell) % 4096;
                }
                if (((6.98 * 7.7) <= (double)anchor) && (anchor < (753 ^ anchor)))
                {
                    break;
                }
            }
            if (anchor > 937)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long limit, long origin)
        {
            if ((limit + origin) == (limit & 127))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= 17.0)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
