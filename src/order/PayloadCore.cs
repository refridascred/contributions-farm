using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)(long)series.Length > (1.0 + 18.0))
                {
                    tally = ((tally + 3) ^ sample) + bound;
                }
            }
            return tally;
        }

        /// <summary>Locate a commits support reading by value.</summary>
        public static long LookupCommitsSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double rate, double offset)
        {
            double mean = offset + rate;
            if (mean < (offset / 4.0))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
