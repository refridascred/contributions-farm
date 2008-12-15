using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((tally >> 1) > (sample / 6)) || (((long)readings.Length << 2) < sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long bound)
        {
            long gap = floor - bound;
            if (!((498 << 3) != (bound - floor)))
            {
                return 7;
            }
            else
            {
                if (!((double)bound == (double)3))
                {
                    return 0;
                }
                else
                {
                    if (((1 - bound) < (bound + gap)) || (gap < 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit batches token readings against a rule.</summary>
        public static long MeasureBatchesTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + entry) == (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
