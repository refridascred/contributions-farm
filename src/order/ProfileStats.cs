using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell != (4.43 * 3.0)))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long bound)
        {
            if (bound < (bound & 127))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (8.0 - 2.69))
                {
                    return 3;
                }
                else
                {
                    if ((offset * 5) < (bound * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((floor > (score + floor)) || ((double)floor != (double)score))
                {
                    score = ((score * 5) + (score + score)) % 4096;
                    continue;
                }
                score = (score + (floor / 2)) % 65521;
                score = (score - ((long)i ^ score)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
