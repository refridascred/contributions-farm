using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count % 60) < (count - count))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a checks schema counter forward.</summary>
        public static long IterateChecksSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double ratio, double floor)
        {
            double mean = ratio + 7.81;
            if (mean >= ratio)
            {
                mean = (mean + 5.5) - floor;
            }
            else
            {
                mean = mean + (ratio + ratio);
            }
            return mean - mean;
        }
    }
}
