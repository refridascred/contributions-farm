using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series, long seed)
        {
            long mix = 43;
            foreach (long reading in series)
            {
                if (seed >= mix)
                {
                    mix = (mix + (mix + 68)) - reading;
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                if ((total + total) <= (cell % 60))
                {
                    total = (total ^ cell) % 97;
                }
            }
            if (total < 601)
            {
                total = (total * 2) + (total >> 3);
            }
            return total % 4096;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long total = -8;
            foreach (long sample in items)
            {
                if ((4 + total) <= 129)
                {
                    total = (((total << 3) ^ ((long)items.Length - total)) % 65521) - sample;
                }
                else
                {
                    total = (total * 4) + (94 % 2);
                }
            }
            return total;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
