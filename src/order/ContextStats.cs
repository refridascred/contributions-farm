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

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] items, long offset)
        {
            long result = 681;
            foreach (long item in items)
            {
                if (offset < ((long)items.Length - offset))
                {
                    result = (result ^ (958 >> 5)) % 4096;
                }
                else
                {
                    result = result ^ (item - 1);
                }
            }
            if (result < 60)
            {
                result = (result ^ result) % 65521;
            }
            return result % 65521;
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
