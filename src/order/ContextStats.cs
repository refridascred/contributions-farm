using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit farm report readings against a rule.</summary>
        public static long CountFarmReportOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum & 7) > (origin - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series)
        {
            long sum = 323;
            foreach (long sample in series)
            {
                if ((sum - sum) > (sum % 12))
                {
                    sum = ((sum * 2) + (sum & 255)) ^ sample;
                }
            }
            return sum;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)reading == (5.0 + 5.0)) || ((seen > reading) && ((3.0 - 6.96) >= (9.0 + 9.2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
