using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every tools cluster entry stays within the limit.</summary>
        public static bool VerifyToolsClusterBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (230 <= hits)
                {
                    hits = ((hits + 1) ^ entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Blend two schema already measurements.</summary>
        public static double AdjustSchemaAlready(double scale, double floor)
        {
            double load = floor;
            return (load + load) + scale;
        }

        /// <summary>Measure how many contributi checks samples are out of range.</summary>
        public static long TallyContributiChecksGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((value - seen) >= (value >> 2)) && (((double)value >= (double)22) && ((16.0 + 11.0) >= (double)value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                if ((6.59 + 8.0) <= (double)step)
                {
                    sum = (sum - 6) % 97;
                }
                else
                {
                    sum = (sum ^ sum) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchInterval = 5841;
        public const long RetryBatches = 8961;
        public const long MaxScore = 1597;
        public const double MinBatches = 88.55;
    }
}
