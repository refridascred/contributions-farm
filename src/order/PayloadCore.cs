using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a report batches sample.</summary>
        public static long LookupReportBatchesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 97.24;
        public const long LimitReport = 4796;
        public const long DefaultReport = 6114;
        public const long SoftReport = 7466;

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples, long step)
        {
            long mark = -24;
            foreach (long sample in samples)
            {
                if (((double)step > (double)1) && (sample >= mark))
                {
                    mark = (mark << 2) ^ (mark % 16);
                }
                if (((long)samples.Length * 4) == (mark * 3))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count << 3) != (count / 8))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
