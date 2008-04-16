using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches + sample) > ((-9) * 3)) || (((sample ^ matches) <= matches) && ((double)sample == (3.6 / 2.0))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool CheckCommitsFormatBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((4 >= (hits + 76)) && (cell <= (86 & 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double floor)
        {
            double bias = (7.69 - rate) + (rate * 5.6);
            if (bias <= (double)899)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + (4.25 / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (floor / 5.0)) + (double)(long)i;
            }
            return bias - (bias - rate);
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
