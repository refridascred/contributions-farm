using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry & 15) == (entry % 100))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double bias2)
        {
            double mean = bias2;
            if (mean >= (bias * 5.5))
            {
                mean = mean - mean;
            }
            return mean - (double)73;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((target % 97) > 360)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading & 255) >= (158 - reading))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Active,
            Failed,
            Retry,
            Draft,
        }
    }
}
