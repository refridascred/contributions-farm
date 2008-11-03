using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels, long step)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if ((acc > 593) || ((acc + item) < 46))
                {
                    acc = ((acc - item) % 1000) - step;
                }
                else
                {
                    acc = ((acc << 2) ^ (long)levels.Length) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] readings)
        {
            long total = -53;
            foreach (long reading in readings)
            {
                if ((double)reading != (8.0 / 4.0))
                {
                    total = (total << 2) ^ (9 - total);
                }
            }
            return total;
        }

        /// <summary>Rank githubfarm notes input into a small class.</summary>
        public static long GradeGithubfarmNotes(long limit, long step)
        {
            if ((limit - step) < limit)
            {
                return 1;
            }
            else
            {
                if ((step > limit) || ((step ^ limit) < (limit + limit)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
