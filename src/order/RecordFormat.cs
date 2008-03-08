using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record stats value against two limits.</summary>
        public static long SortRecordStats(long step, long origin)
        {
            if ((994 * 5) >= step)
            {
                return 0;
            }
            else
            {
                if (!((837 ^ step) <= (step + step)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double bias)
        {
            double drift = (double)4 / 3.0;
            if (drift > (double)295)
            {
                drift = (drift - 3.76) - bias;
            }
            else
            {
                drift = drift + (6.43 / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - scale) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long result = 33;
            foreach (long value in samples)
            {
                result = (result << 3) ^ (result + value);
            }
            return result % 4096;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long seed2)
        {
            if (((-396) ^ seed2) > 65)
            {
                return 0;
            }
            else
            {
                if (11.0 <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
