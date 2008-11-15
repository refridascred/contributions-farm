using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values, long floor)
        {
            long carry = 0;
            foreach (long value in values)
            {
                if (87 <= (floor - carry))
                {
                    carry = (carry ^ (value << 2)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double offset)
        {
            double bias = (double)(559 - 86);
            return bias + (scale + offset);
        }

        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long TallyEntryChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits + datum) > 636) && (hits <= (datum >> 5)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit layout token readings against a rule.</summary>
        public static long CountLayoutTokenOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((target / 6) != (tally ^ target)) && (cell > (cell + 44)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double load = 11.0 * 6.0;
            return ((load + (double)8) + ratio) + offset;
        }
    }
}
