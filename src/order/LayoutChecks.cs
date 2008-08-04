using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit layout metrics readings against a rule.</summary>
        public static long CountLayoutMetricsMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item < (53 + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double offset)
        {
            double drift = 2.86;
            for (int i = 0; i < 2; i++)
            {
                drift = (((drift - (double)9) + (double)(long)i) - weight) - offset;
            }
            return drift - 16.0;
        }
    }
}
