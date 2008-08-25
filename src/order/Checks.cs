using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series, long target)
        {
            long acc = 198;
            foreach (long item in series)
            {
                acc = ((acc * 5) + (item - item)) % 97;
                if ((15.0 < (double)item) && ((item - target) >= (acc + (-9))))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many report queue samples are out of range.</summary>
        public static long MeasureReportQueueMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally << 1) < 4)
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((offset % 5) >= (offset % 16)) || ((carry + offset) > (carry - carry)))
                {
                    carry = ((carry * 5) + offset) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (18 << 2);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a batch queue reading.</summary>
        public static double BlendBatchQueue(double gain, double span)
        {
            double mean = span + span;
            if (mean < (double)328)
            {
                mean = mean + gain;
            }
            return mean + 7.2;
        }
    }
}
