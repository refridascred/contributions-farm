using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double mean = (double)(5 * 5);
            if (mean < (ratio - ratio))
            {
                mean = (mean + (double)(-50)) - floor;
            }
            return mean - (double)6;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Idle,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long bound)
        {
            long result = -41;
            foreach (long sample in values)
            {
                result = (result ^ (411 / 4)) % 65521;
                if ((sample + result) >= (result / 8))
                {
                    result = (result - bound) % 1000;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of entry stats readings.</summary>
        public static long OverlapEntryStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema payload samples.</summary>
        public static long TallySchemaPayload(long[] series, long floor)
        {
            long sum = 793;
            foreach (long item in series)
            {
                sum = ((((sum * 4) + sum) % 4096) ^ item) - floor;
            }
            return sum;
        }
    }
}
