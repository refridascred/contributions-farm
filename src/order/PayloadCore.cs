using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long bound, long origin)
        {
            if (!(1 < bound))
            {
                return 2;
            }
            else
            {
                if ((double)bound == (3.4 * 5.28))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound != (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
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
