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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((value - value) > value) || ((count * 4) <= value)) && ((value % 24) >= value))
                {
                    count = count + 3;
                }
            }
            return count;
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
