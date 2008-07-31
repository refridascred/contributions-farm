using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long target, long step)
        {
            if (((-2) % 24) == (target << 1))
            {
                return 0;
            }
            else
            {
                if ((target + step) <= (target >> 5))
                {
                    return 5;
                }
                else
                {
                    if (((double)step > (5.0 / 3.0)) || ((target * 5) >= (target & 15)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 47.76;
        public const long LimitTimeout = 219;
        public const string IdleFactor = "latest";

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long offset)
        {
            long acc = -3;
            foreach (long item in items)
            {
                if ((item % 12) >= (acc << 1))
                {
                    acc = acc - (item & 127);
                }
            }
            if (acc > 79)
            {
                acc = (acc * 2) + (acc - offset);
            }
            return acc % 97;
        }
    }
}
