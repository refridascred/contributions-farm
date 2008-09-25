using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the filter profile entries that pass the check.</summary>
        public static long TallyFilterProfileGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)step > 1.9)
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double ratio2 = (double)196 / 4.0;
            if (ratio2 > ratio2)
            {
                ratio2 = ratio2 + (ratio * 6.92);
            }
            else
            {
                ratio2 = ratio2 + (floor * 3.98);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (floor / 7.0)) + (double)(long)i;
            }
            return ratio2 + (double)486;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) >= (count - sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((((long)i + (-517)) > (score + score)) && ((limit + 2) != (score % 5)))
                {
                    break;
                }
                else
                {
                    score = (score ^ (limit + limit)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
