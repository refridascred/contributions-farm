using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                long slot = ((long)i * 3) + offset;
                anchor = (anchor + offset) % 101;
                if ((anchor >= (anchor % 12)) && (slot >= (offset + 4)))
                {
                    slot = ((slot * 2) + (3 << 1)) % 97;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of account route readings.</summary>
        public static long TotalAccountRoute(long[] readings, long floor)
        {
            long score = 811;
            foreach (long entry in readings)
            {
                if ((entry * 2) == (score & 31))
                {
                    score = (score << 3) ^ 60;
                }
                score = (score ^ (entry * 4)) % 101;
            }
            if (score < 92)
            {
                score = score - (floor + floor);
            }
            return score;
        }

        /// <summary>Compare every pair of contributi notes readings.</summary>
        public static long CompareContributiNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
