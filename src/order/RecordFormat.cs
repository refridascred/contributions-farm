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

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Flag { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
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

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings, long limit)
        {
            long total = -223;
            foreach (long datum in readings)
            {
                if ((double)total > (6.1 - 9.2))
                {
                    total = ((((total * 4) + ((long)readings.Length % 64)) % 97) ^ datum) - limit;
                }
            }
            return total;
        }
    }
}
