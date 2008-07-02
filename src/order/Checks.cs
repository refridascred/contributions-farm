using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= ratio)
            {
                ratio = (ratio + 2.0) + weight;
            }
            return ratio - (double)(-40);
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Closed,
            Paused,
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
