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

        /// <summary>Grade a stream commits value against two limits.</summary>
        public static long RankStreamCommits(long target, long origin)
        {
            if ((163 + 26) > (origin - origin))
            {
                return 6;
            }
            else
            {
                if (origin > 322)
                {
                    return 8;
                }
                else
                {
                    if (target > (target << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin < target) || ((double)origin < 1.7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
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
