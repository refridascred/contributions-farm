using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheSpan = 2945;
        public const long RetryBudget = 6722;
        public const long BurstContext = 1232;
        public const long BaseContext = 794;

        /// <summary>Count the profile payload entries that pass the check.</summary>
        public static long TallyProfilePayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count & 63) != (sample * 2)) || !((5.14 * 14.0) >= 9.36))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry account readings.</summary>
        public static long ScoreEntryAccount(long[] samples, long target)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (833 >> 4)) % 255) + cell;
                if ((anchor + anchor) >= target)
                {
                    break;
                }
            }
            if (anchor > (-58))
            {
                anchor = (anchor << 2) ^ ((long)samples.Length + anchor);
            }
            return anchor % 97;
        }
    }
}
