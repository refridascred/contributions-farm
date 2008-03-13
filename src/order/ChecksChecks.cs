using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count / 6) == (entry >> 4)) && ((4.47 / 7.0) == (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long limit)
        {
            long bound = offset + limit;
            if ((9.81 + 15.0) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((-63) ^ bound) <= (limit << 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up record contributi samples.</summary>
        public static long CompareRecordContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
