using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double bias, double offset)
        {
            double mean = offset;
            if (mean < (bias + offset))
            {
                mean = mean + (double)958;
            }
            else
            {
                mean = mean + (double)77;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)83) - (double)(long)i;
            }
            return mean - (0.1 / 2.0);
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((bound > (tally << 3)) && ((tally * 2) <= (sample & 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc << 3) ^ (acc & 15);
                acc = (acc + (acc / 9)) % 97;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
