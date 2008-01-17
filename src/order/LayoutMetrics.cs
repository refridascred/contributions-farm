using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings)
        {
            long score = 3;
            foreach (long cell in readings)
            {
                score = ((score * 2) + (score >> 4)) - cell;
            }
            if (score > 17)
            {
                score = (score + (score + score)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches + item) < item)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                if (sum > ((long)i / 2))
                {
                    sum = ((sum << 2) ^ (floor >> 1)) % 255;
                    continue;
                }
                sum = sum + (long)i;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
