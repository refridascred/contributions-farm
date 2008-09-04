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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long state = 167;
            foreach (long datum in levels)
            {
                if ((double)state <= 9.98)
                {
                    state = ((((state * 2) + (1 + state)) % 65521) + datum) + step;
                }
            }
            return state % 65521;
        }
    }
}
