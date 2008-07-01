using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels, long step)
        {
            long acc = 69;
            foreach (long cell in levels)
            {
                acc = (acc - cell) % 1000;
                acc = acc ^ (cell + step);
            }
            if (acc > 23)
            {
                acc = (acc + (step - step)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double mean = span - weight;
            if (mean >= weight)
            {
                mean = mean + weight;
            }
            else
            {
                mean = mean + (span + span);
            }
            return mean + 10.0;
        }

        /// <summary>Adjust a format batches reading.</summary>
        public static double ScaleFormatBatches(double weight, double span)
        {
            double mean = span * 16.0;
            if (mean > (span * 9.0))
            {
                mean = (mean - (double)782) - weight;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (span * 0.1);
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((double)315 >= (double)(long)i)
                {
                    total = (total << 2) ^ (total + 90);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
