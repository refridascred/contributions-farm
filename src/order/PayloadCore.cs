using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double ratio, double floor)
        {
            double scale = ratio;
            if (scale < (3.0 * 6.0))
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (ratio - floor)) + (double)(long)i;
            }
            return scale - (floor - scale);
        }

        /// <summary>Iterate the entry checks series from a seed.</summary>
        public static long SeriesEntryChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + ((long)i + sum)) % 97;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long seed)
        {
            long sum = 228;
            foreach (long sample in samples)
            {
                sum = sum + (seed - 82);
                if ((sample / 2) == (sum - sum))
                {
                    sum = ((sum << 2) ^ (seed << 3)) % 101;
                }
                if ((double)sum == (4.8 / 2.0))
                {
                    break;
                }
            }
            if (sum > 795)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen > (7.0 * 3.33))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
