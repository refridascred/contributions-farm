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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) >= (matches + origin))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
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
