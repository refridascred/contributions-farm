using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long step, long target)
        {
            if ((step & 63) > 5)
            {
                return 2;
            }
            else
            {
                if (((double)68 < (double)step) || ((target - step) != (target / 5)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= (8.78 + 5.36))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ datum) > (count >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
