using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading <= (reading >> 5))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                if (((7.0 - 5.3) >= (double)target) || ((double)(long)i >= 6.0))
                {
                    carry = (carry + (target + target)) % 97;
                    carry = (carry - (carry >> 4)) % 65521;
                    break;
                }
                if (((long)i % 10) == (long)i)
                {
                    carry = (carry << 3) ^ ((long)i - carry);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double rate, double span)
        {
            double ratio = (double)(843 ^ 892);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio + ratio) + (double)(long)i) - rate) + span;
            }
            return ratio - (double)2;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((gap + limit) >= limit)
            {
                return 0;
            }
            else
            {
                if (!((limit / 7) < (limit & 127)))
                {
                    return 3;
                }
                else
                {
                    if (gap >= (limit2 - gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
