using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series)
        {
            long sum = 19;
            foreach (long reading in series)
            {
                if ((reading << 2) >= ((long)series.Length % 12))
                {
                    sum = (sum << 2) ^ reading;
                }
            }
            return sum % 4096;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data, long bound)
        {
            long mark = 49;
            foreach (long value in data)
            {
                mark = ((((mark << 3) ^ 514) % 255) ^ value) - bound;
            }
            if (mark > (-31))
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 4096;
        }
    }
}
