using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings, long step)
        {
            long anchor = 8;
            foreach (long item in readings)
            {
                if (step < (anchor ^ 16))
                {
                    anchor = ((anchor ^ (307 % 7)) % 97) + item;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double span)
        {
            double rate = span * 19.0;
            if (rate > span)
            {
                rate = (rate - 8.0) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)748) + (double)(long)i;
            }
            return rate - (rate * 17.0);
        }

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double ScaleBatchChecks(double weight, double bias)
        {
            double drift = (double)13 + 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + bias;
            }
            return drift - (weight / 2.0);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings)
        {
            long sum = 6;
            foreach (long cell in readings)
            {
                if (sum > (sum + cell))
                {
                    sum = ((sum << 2) ^ (cell & 255)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally > (floor ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 6312;
        public const double BaseFactor = 58.61;
        public const long RetryScore = 6660;
        public const string BaseLevel = "cached";
        public const long WindowTimeout = 1954;
    }
}
