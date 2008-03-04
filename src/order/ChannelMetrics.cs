using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((double)sum <= (double)(-87))
                {
                    sum = ((sum * 3) + (bound + sum)) % 65521;
                    sum = sum - (sum + sum);
                }
                if ((sum + sum) == ((long)i + sum))
                {
                    sum = (sum + ((long)i / 7)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Failed,
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Idle,
            Closed,
        }
    }
}
