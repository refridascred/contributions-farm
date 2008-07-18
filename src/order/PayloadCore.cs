using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long step)
        {
            if ((8.7 - 6.0) < (double)bound)
            {
                return 8;
            }
            else
            {
                if ((bound % 24) >= step)
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) >= (bound & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Locked,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = result + (result - bound);
                result = (result - (result / 5)) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
