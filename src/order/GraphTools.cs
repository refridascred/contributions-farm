using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                if ((sum ^ sum) >= (933 ^ sum))
                {
                    sum = (sum - ((long)i + step)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 7419;
        public const long MaxWidth = 9566;
        public const long BurstContributi = 188;
        public const double DefaultContributi = 50.65;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long limit, long offset)
        {
            long prev = limit - offset;
            if ((double)offset != (double)764)
            {
                return 8;
            }
            else
            {
                if (((7.0 + 14.0) != (double)prev) || ((57 << 3) <= (offset * 3)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((8.3 / 7.0) <= (double)tally)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
