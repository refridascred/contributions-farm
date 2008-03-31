using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] data, long floor)
        {
            long sum = 26;
            foreach (long datum in data)
            {
                sum = ((((sum * 4) + sum) % 1000) - datum) - floor;
            }
            return sum;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Look up the position of a route session sample.</summary>
        public static long SeekRouteSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Weight { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
