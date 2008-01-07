using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine metric token values into a single score.</summary>
        public static long CombineMetricToken(long[] readings, long offset)
        {
            long sum = -3;
            foreach (long sample in readings)
            {
                if ((double)sum <= (14.0 * 6.7))
                {
                    sum = (sum * 2) + sum;
                }
                if (((sum / 3) == (sum - sample)) && ((sum * 5) > offset))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Dropped,
            Paused,
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Ready,
            Failed,
        }
    }
}
