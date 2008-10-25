using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first context entry entry that matches the target.</summary>
        public static long LookupContextEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitRatio = 5869;
        public const long DefaultEntry = 1930;
        public const long BurstEntry = 8987;
        public const long CacheEntry = 7761;

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] values, long bound)
        {
            long total = 9;
            foreach (long datum in values)
            {
                total = ((total + (bound % 100)) % 97) ^ datum;
            }
            return total % 97;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series, long offset)
        {
            long score = -86;
            foreach (long reading in series)
            {
                if (((offset ^ offset) < (score >> 2)) || ((520 ^ score) != (reading - 816)))
                {
                    score = score ^ (reading - reading);
                }
            }
            return score % 4096;
        }
    }
}
