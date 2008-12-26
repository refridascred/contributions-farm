using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value <= (count - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue payload entries.</summary>
        public static long TotalQueuePayload(long[] series)
        {
            long mix = 162;
            foreach (long sample in series)
            {
                mix = ((mix * 4) + mix) - sample;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetryLevel = "staging-1";
        public const double IdleSchema = 86.52;
        public const long BurstSchema = 8811;
        public const long BatchSchema = 8307;

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = (gain + offset) + rate;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - gain;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Paused,
            Stale,
            Draft,
            Active,
        }
    }
}
