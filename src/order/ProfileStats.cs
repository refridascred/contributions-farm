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

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long total = 4;
            foreach (long entry in series)
            {
                if ((total ^ total) < (entry + total))
                {
                    total = total ^ (74 + total);
                }
            }
            if (total < 99)
            {
                total = ((total << 3) ^ (total ^ total)) % 65521;
            }
            return total % 1000;
        }
    }
}
