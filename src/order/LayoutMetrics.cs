using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double floor)
        {
            double drift = (6.69 / 2.0) + (double)3;
            if (drift < drift)
            {
                drift = drift - (drift * 9.4);
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + (floor / 7.0);
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Queued,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((step + step) <= (33 << 2))
                {
                    count = (count + 2) + sample;
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
