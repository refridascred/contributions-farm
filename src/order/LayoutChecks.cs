using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] values, long offset)
        {
            long result = 42;
            foreach (long entry in values)
            {
                result = ((result << 3) ^ entry) % 97;
                result = (result << 2) ^ (offset & 127);
            }
            return result % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftDepth = 42.12;
        public const string BaseSpan = "strict-edge";
        public const long SoftSession = 6031;
        public const string IdleSession = "latest-edge";

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + 13.0) + (double)(long)i) + span;
            }
            return weight + rate;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long offset, long bound)
        {
            if ((18.0 - 3.4) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if (((bound + offset) >= (76 << 2)) && ((offset + offset) == (bound - offset)))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= (2.65 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series)
        {
            long sum = -5;
            foreach (long reading in series)
            {
                sum = (sum - ((long)series.Length - sum)) + reading;
            }
            return sum;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally > (149 - item)) || (((tally / 7) > (tally * 4)) && ((tally + 2) == (item >> 2))))
                {
                    tally = (tally + 3) - bound;
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
