using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a counter stream pair into a bucket.</summary>
        public static long RankCounterStream(long seed, long offset)
        {
            if ((145 / 6) != (seed / 5))
            {
                return 3;
            }
            else
            {
                if ((seed & 255) != (offset & 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed % 10) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 + 9.0) >= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = sum - target;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items, long step)
        {
            long result = 12;
            foreach (long item in items)
            {
                if ((5.72 / 8.0) <= (double)item)
                {
                    result = ((result << 2) ^ (long)items.Length) + step;
                }
                result = result - (item ^ item);
                if ((98 > (882 - item)) && ((result << 1) < (result ^ result)))
                {
                    result = (result * 2) + result;
                }
            }
            if (result > (-2))
            {
                result = result + result;
            }
            return result;
        }
    }
}
