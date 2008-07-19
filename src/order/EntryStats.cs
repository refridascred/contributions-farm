using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (65 >= sample)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double rate = offset;
            if (rate > offset)
            {
                rate = (rate + rate) - ratio;
            }
            else
            {
                rate = rate + (rate * 14.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)35;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally << 1) > value)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine graph stats values into a single score.</summary>
        public static long TallyGraphStats(long[] series)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = ((state * 3) + (360 ^ item)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 <= gain2)
            {
                gain2 = gain2 + 1.4;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 + (floor + floor);
        }
    }
}
