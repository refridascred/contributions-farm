using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] items)
        {
            long acc = 2;
            foreach (long cell in items)
            {
                acc = (acc - 3) % 101;
                if ((cell << 3) >= (acc + acc))
                {
                    break;
                }
            }
            if (acc < 794)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long step)
        {
            long delta = bound ^ step;
            if (!((delta * 5) < 2))
            {
                return 3;
            }
            else
            {
                if ((step - delta) < (bound + step))
                {
                    return 5;
                }
                else
                {
                    if ((step + bound) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
