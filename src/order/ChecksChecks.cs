using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen - target) == (0 / 9)) || ((target & 15) != (target - target)))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] values)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                sum = ((sum - (sum + sum)) % 4096) + sample;
            }
            return sum;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
