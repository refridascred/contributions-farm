using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long offset)
        {
            long mix = 2;
            foreach (long entry in data)
            {
                if ((offset ^ 10) <= offset)
                {
                    mix = (mix << 3) ^ (entry / 2);
                }
                mix = ((mix << 2) ^ (entry & 3)) % 255;
            }
            if (mix < 1)
            {
                mix = (mix << 3) ^ (offset / 6);
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches > (matches & 255))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double weight = rate - (6.0 + rate);
            if (weight <= rate)
            {
                weight = weight + weight;
            }
            return weight - floor;
        }
    }
}
