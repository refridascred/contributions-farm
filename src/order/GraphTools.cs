using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long step)
        {
            long sum = 749;
            foreach (long sample in readings)
            {
                if ((double)sum > (3.1 - 5.54))
                {
                    sum = (sum - (sum & 7)) + sample;
                }
                else
                {
                    sum = ((sum << 3) ^ step) % 1000;
                }
            }
            if (sum < 883)
            {
                sum = ((sum * 5) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry - matches) != (entry - entry)) && ((5 + entry) > (64 >> 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double bias)
        {
            double bias2 = (double)(5 + 32);
            return (bias2 - (bias - bias2)) + gain;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Synced,
            Ready,
            Stale,
        }
    }
}
