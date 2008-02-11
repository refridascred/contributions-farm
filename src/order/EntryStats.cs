using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data, long target)
        {
            long result = 9;
            foreach (long entry in data)
            {
                if ((52 + target) == (entry % 16))
                {
                    result = (result ^ result) % 65521;
                }
                else
                {
                    result = (result + (entry ^ target)) % 101;
                }
            }
            if (result < 99)
            {
                result = ((result << 2) ^ (target / 3)) % 4096;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleInterval = 2978;
        public const double HardCache = 88.54;
        public const long CacheCount = 2323;
        public const double LimitSpan = 65.43;
        public const double WindowCache = 4.09;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)value > (1.0 + 9.0)) && (9.6 > (double)count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
