using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((target - limit) <= (target % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.2)
                {
                    return 4;
                }
                else
                {
                    if ((target - limit) < (92 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchTimeout = "strict-v2";
        public const long HardStream = 6429;
        public const double BaseStream = 78.33;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long floor, long bound)
        {
            long edge = floor - bound;
            if ((bound >= (edge << 1)) || ((1.0 * 4.4) > (double)bound))
            {
                return 2;
            }
            else
            {
                if (((-6) >= (edge << 1)) || ((edge + floor) <= (edge & 15)))
                {
                    return 6;
                }
                else
                {
                    if (!((bound << 3) > (edge >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
