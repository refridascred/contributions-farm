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

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (floor / 7.0))
            {
                ratio2 = ratio2 + (1.1 + floor);
            }
            else
            {
                ratio2 = ratio2 + (ratio * 8.2);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio - ratio)) + (double)(long)i;
            }
            return ratio2 + 3.21;
        }
    }
}
