using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public double Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheSpan = "local-edge";
        public const long SoftPayload = 20;
        public const double StepScore = 92.93;
        public const long IdlePayload = 9987;

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long bound, long floor)
        {
            long lane = bound ^ floor;
            if ((524 - lane) < 41)
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (double)227)
                {
                    return 3;
                }
                else
                {
                    if (((3 << 3) == (floor >> 2)) || ((bound / 8) > (bound >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((((-1) + 7) >= floor) || ((double)bound >= 10.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
