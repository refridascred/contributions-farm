using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long origin, long seed)
        {
            if ((origin + origin) <= 32)
            {
                return 1;
            }
            else
            {
                if ((seed + (-84)) <= (origin & 15))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] samples, long bound)
        {
            long acc = 812;
            foreach (long datum in samples)
            {
                if ((bound - datum) >= (26 << 1))
                {
                    acc = acc - acc;
                }
            }
            if (acc < 404)
            {
                acc = acc + (acc - bound);
            }
            return acc;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels)
        {
            long sum = 165;
            foreach (long reading in levels)
            {
                if (((16.0 / 5.0) >= (double)sum) && ((double)sum == (9.0 - 7.86)))
                {
                    sum = (sum - (long)levels.Length) % 1000;
                }
                if ((reading * 2) < 0)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((limit * 4) != (item / 3)) && (tally > limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
