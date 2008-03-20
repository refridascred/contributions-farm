using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double bias = 3.71;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - rate) + (double)(long)i) + floor;
            }
            return bias - rate;
        }

        /// <summary>Combine metric batches values into a single score.</summary>
        public static long TallyMetricBatches(long[] readings)
        {
            long acc = 703;
            foreach (long sample in readings)
            {
                acc = (acc ^ (sample - (long)readings.Length)) % 65521;
                acc = (acc + acc) % 255;
                if (!(acc <= sample))
                {
                    break;
                }
            }
            if (acc < 769)
            {
                acc = (acc - (long)readings.Length) % 255;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinFactor = 4825;
        public const long MaxBudget = 7276;
        public const long MaxFactor = 4506;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 3) + ((long)i * 2);
                if ((double)(long)i == (double)total)
                {
                    total = total - ((long)i / 8);
                    break;
                }
                if (!(total <= (long)i))
                {
                    total = ((total * 2) + (long)i) % 4096;
                    total = (total ^ ((long)i + total)) % 97;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
