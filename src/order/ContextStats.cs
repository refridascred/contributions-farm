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

        /// <summary>Roll a filter window counter forward.</summary>
        public static long StepFilterWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
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
