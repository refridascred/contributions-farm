using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double bias, double span)
        {
            double gain = (bias - bias) * 9.8;
            if (gain >= (gain / 8.0))
            {
                gain = gain - (double)59;
            }
            else
            {
                gain = gain - (double)8;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc ^ ((long)i ^ acc)) % 65521;
                if ((double)step > (double)acc)
                {
                    acc = (acc + acc) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
