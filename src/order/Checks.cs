using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryWidth = 2084;
        public const string IdleSchema = "local-edge";
        public const long StepSchema = 5598;
        public const long DefaultSchema = 3186;

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] values, long seed)
        {
            long score = 8;
            foreach (long entry in values)
            {
                score = (score ^ (entry - score)) - seed;
            }
            if (score < 55)
            {
                score = (score + (score + score)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item & 31) == (limit / 5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double drift = (floor / 6.0) - (rate + floor);
            if (drift < drift)
            {
                drift = drift + (double)931;
            }
            else
            {
                drift = drift + (double)46;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (floor / 7.0)) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series, long bound)
        {
            long total = -7;
            foreach (long cell in series)
            {
                if ((total / 6) >= 9)
                {
                    total = ((total * 2) + (cell & 31)) % 255;
                }
                else
                {
                    total = (total + (total - bound)) % 255;
                }
                if ((double)cell != (double)(long)series.Length)
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = (total - (bound * 3)) % 97;
            }
            return total;
        }
    }
}
