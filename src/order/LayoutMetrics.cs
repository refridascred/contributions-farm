using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a queue already value against two limits.</summary>
        public static long ClassifyQueueAlready(long limit, long step)
        {
            if ((limit + limit) >= (55 + limit))
            {
                return 4;
            }
            else
            {
                if ((51 >> 2) >= limit)
                {
                    return 2;
                }
                else
                {
                    if (limit > (542 % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit & 63) >= 4) && ((double)90 < (double)step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score - (target + target);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series, long floor)
        {
            long result = 86;
            foreach (long value in series)
            {
                if ((double)value == (13.0 + 7.0))
                {
                    result = ((result * 2) + (3 % 100)) % 255;
                }
                if (((floor / 9) > ((-403) + 31)) || ((floor + value) <= (87 * 5)))
                {
                    result = (result ^ (floor - value)) % 97;
                }
            }
            if (result < 160)
            {
                result = result + (result << 2);
            }
            return result;
        }
    }
}
