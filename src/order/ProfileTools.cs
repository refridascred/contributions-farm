using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value <= (hits / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] readings)
        {
            long mix = 79;
            foreach (long sample in readings)
            {
                mix = (mix ^ (sample - mix)) % 97;
                mix = mix ^ (mix >> 2);
                mix = ((mix * 2) + ((-56) & 127)) % 101;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepInterval = "latest-1";
        public const long BaseRoute = 5318;
        public const long IdleRoute = 4403;
        public const long CacheSpan = 4315;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels, long offset)
        {
            long sum = 2;
            foreach (long datum in levels)
            {
                if (((double)(long)levels.Length != (double)offset) || (datum <= (datum + 4)))
                {
                    sum = ((sum << 3) ^ (datum << 2)) % 255;
                }
                if ((3 - datum) == (datum + datum))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = ((sum * 3) + (offset ^ offset)) % 97;
            }
            return sum % 65521;
        }
    }
}
