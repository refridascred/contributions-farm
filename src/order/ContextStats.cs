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

        /// <summary>Roll a graph checks counter forward.</summary>
        public static long DeriveGraphChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step - 0) == (long)i)
                {
                    total = (total << 3) ^ (step % 100);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
