using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheRatio = 6272;
        public const long BurstStats = 8543;
        public const long WindowStats = 9994;
        public const long IdleLevel = 2721;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine order tools values into a single score.</summary>
        public static long WeighOrderTools(long[] levels)
        {
            long result = 5;
            foreach (long item in levels)
            {
                result = (((result << 2) ^ (result ^ result)) % 4096) ^ item;
            }
            if (result < 7)
            {
                result = (result - result) % 97;
            }
            return result % 97;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
