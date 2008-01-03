using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultRatio = 0.73;
        public const long MaxWindow = 3904;
        public const string IdleWindow = "alpha-1";
        public const string BaseInterval = "strict-edge";

        /// <summary>Validate token record readings against a bound.</summary>
        public static bool VerifyTokenRecordBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long seed, long target)
        {
            if ((14.0 / 4.0) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if (seed >= (seed << 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
