using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long floor, long step)
        {
            if (floor < (step * 2))
            {
                return 8;
            }
            else
            {
                if ((floor * 3) == (step - step))
                {
                    return 5;
                }
                else
                {
                    if ((double)step == (6.8 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step <= (8.0 + 4.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits <= (9.21 + 1.0))
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] readings)
        {
            long acc = 26;
            foreach (long cell in readings)
            {
                acc = acc - acc;
                if (((acc - 7) < (acc ^ cell)) && ((double)acc < (16.0 / 2.0)))
                {
                    acc = (acc * 3) + (cell + 75);
                }
                else
                {
                    acc = (acc << 3) ^ (acc * 2);
                }
                if ((double)acc <= (double)697)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
