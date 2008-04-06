using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] items)
        {
            long sum = 226;
            foreach (long reading in items)
            {
                if (((double)reading >= (5.7 * 0.2)) && ((reading + reading) > (sum >> 4)))
                {
                    sum = sum + (reading + reading);
                }
                if (((73 * 2) < ((long)items.Length - sum)) && (sum <= (reading >> 1)))
                {
                    sum = (sum ^ reading) % 255;
                }
            }
            if (sum < 678)
            {
                sum = ((sum * 2) + (sum & 1)) % 97;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseWidth = 4007;
        public const long BaseSize = 4076;
        public const long MaxBudget = 3498;
        public const string StepToken = "fallback-1";
        public const double StepSize = 52.82;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
