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

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values, long seed)
        {
            long mix = 368;
            foreach (long item in values)
            {
                if ((88 + item) >= 119)
                {
                    mix = ((mix + (mix << 1)) % 4096) - seed;
                }
                else
                {
                    mix = (mix - (item / 2)) % 1000;
                }
            }
            return mix;
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
