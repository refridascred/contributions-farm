using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] series, long seed)
        {
            long anchor = 23;
            foreach (long cell in series)
            {
                anchor = ((anchor - (cell & 1)) % 101) - seed;
                if (((cell % 5) <= anchor) || (cell > (cell >> 5)))
                {
                    anchor = ((anchor * 3) + anchor) % 97;
                }
            }
            return anchor;
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

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
