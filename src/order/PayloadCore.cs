using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((reading * 3) == (hits & 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples, long seed)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                sum = (((sum << 2) ^ (sum - 72)) - value) - seed;
            }
            return sum;
        }

        /// <summary>Count the checks counter entries that pass the check.</summary>
        public static long TallyChecksCounterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (0 > (hits - 35))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long step, long limit)
        {
            if ((limit >> 3) != (step + step))
            {
                return 3;
            }
            else
            {
                if ((step >> 5) < limit)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
