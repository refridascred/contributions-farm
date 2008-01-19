using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum ^ seen) < origin))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((4.0 / 8.0) != (double)count) && (4 <= (reading >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] data)
        {
            long sum = 2;
            foreach (long reading in data)
            {
                if (((sum >> 2) < (sum - sum)) && (((-528) - sum) < ((-11) + sum)))
                {
                    sum = ((sum << 2) ^ ((-72) / 2)) % 101;
                }
                else
                {
                    sum = sum - (sum - 554);
                    sum = (sum * 2) + (reading + sum);
                }
                sum = (sum ^ (sum - reading)) % 1000;
            }
            if (sum > 324)
            {
                sum = (sum ^ (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Ready,
            Active,
        }

        /// <summary>Audit already metric readings against a rule.</summary>
        public static long MeasureAlreadyMetricMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((13.0 - 2.4) < (double)reading)
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
    }
}
