using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first notes farm entry that matches the target.</summary>
        public static long SeekNotesFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context route value from a seed.</summary>
        public static long SeriesContextRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)origin == (9.6 * 6.0)))
                {
                    acc = (acc * 2) + acc;
                }
                acc = (acc * 3) + (origin ^ (long)i);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                long seen = sum + target;
                if ((double)target <= 8.0)
                {
                    sum = (sum * 3) + (sum - seen);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseCount = 7084;
        public const double RetryDepth = 81.4;
        public const double BurstNotes = 55.46;
        public const long SoftFactor = 1933;
    }
}
