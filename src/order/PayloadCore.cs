using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + 67) != (origin << 2))
                {
                    continue;
                }
                else
                {
                    state = (state << 3) ^ (8 / 8);
                    state = ((state * 5) + origin) % 1000;
                }
                state = state ^ state;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a support buffer counter forward.</summary>
        public static long RollSupportBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                double ratio = (double)seed + (double)(long)i;
                if (((ratio / 5.0) <= ratio) || (ratio < 9.51))
                {
                    sum = sum + (sum << 2);
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Dropped,
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Ready,
            Failed,
            Stale,
        }
    }
}
