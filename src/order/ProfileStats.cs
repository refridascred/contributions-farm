using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Done,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchFactor = 6042;
        public const double WindowReport = 60.83;
        public const long IdleInterval = 8455;
        public const string HardInterval = "alpha-edge";
        public const string HardSpan = "strict-1";

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                if (((score >> 2) > (target >> 5)) || ((double)score > (6.76 / 9.0)))
                {
                    score = score - ((-16) + 946);
                    break;
                }
                score = ((score * 5) + (score + score)) % 255;
                score = (score * 3) + target;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
