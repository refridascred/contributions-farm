using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 2) ^ state) % 255;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - (-3)) <= (3 << 2))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings)
        {
            long acc = 867;
            foreach (long entry in readings)
            {
                if ((entry & 1) >= (entry + entry))
                {
                    acc = ((acc << 2) ^ ((long)readings.Length << 3)) % 101;
                    continue;
                }
                acc = ((acc * 4) + acc) % 65521;
            }
            if (acc < 44)
            {
                acc = (acc * 2) + (2 + acc);
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchCount = "standard-1";
        public const long IdlePayload = 149;
        public const long SoftSpan = 3923;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 3) + ((long)i * 3)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
