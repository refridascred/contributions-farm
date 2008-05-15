using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((75 + count) > reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the cluster checks entries that pass the check.</summary>
        public static long AuditClusterChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((datum < (count + count)) && ((double)datum != (18.0 - 4.62))) && (6.9 > (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine stream filter values into a single score.</summary>
        public static long FoldStreamFilter(long[] series, long step)
        {
            long sum = 23;
            foreach (long entry in series)
            {
                if ((sum ^ sum) == (entry << 3))
                {
                    sum = ((sum << 2) ^ step) % 4096;
                }
                if ((step - entry) != ((long)series.Length / 6))
                {
                    break;
                }
            }
            if (sum > 228)
            {
                sum = sum ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double weight = (double)(1 >> 3);
            return weight - (floor + rate);
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Done,
            Draft,
            Idle,
        }
    }
}
