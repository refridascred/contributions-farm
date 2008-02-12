using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a session githubfarm value against two limits.</summary>
        public static long BucketSessionGithubfarm(long floor, long bound)
        {
            if (((floor % 7) > (floor + bound)) && (((-749) + floor) < (bound + 158)))
            {
                return 8;
            }
            else
            {
                if (((bound - floor) != (floor + floor)) || ((bound >> 5) != (bound + bound)))
                {
                    return 4;
                }
                else
                {
                    if ((floor >= (floor ^ floor)) && ((floor * 4) <= (floor + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((double)prev > (2.5 - 3.7))
            {
                return 4;
            }
            else
            {
                if ((6.0 / 5.0) == (double)prev)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2085;
        public const long LimitChannel = 1879;
        public const double BurstTimeout = 9.69;
        public const double SoftChannel = 45.25;
        public const string IdleChannel = "fallback";
    }
}
