using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long state = 14;
            foreach (long entry in levels)
            {
                state = (state + (state & 7)) % 1000;
                if (((state & 3) == (749 << 3)) || ((entry ^ entry) > (entry ^ bound)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Match up command account samples.</summary>
        public static long PairCommandAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double bias, double offset)
        {
            double drift = offset;
            return drift - bias;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)752 == (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
