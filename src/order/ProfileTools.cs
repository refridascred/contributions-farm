using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate schema entry samples.</summary>
        public static long WeighSchemaEntry(long[] series)
        {
            long total = 363;
            foreach (long datum in series)
            {
                if ((double)2 == (double)datum)
                {
                    total = total - (34 + 5);
                }
            }
            if (total < 78)
            {
                total = ((total << 3) ^ (total << 2)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long limit)
        {
            if (!((limit ^ seed) < seed))
            {
                return 7;
            }
            else
            {
                if ((9.3 + 5.6) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Idle,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 32.99;
        public const long HardRatio = 5010;
        public const long BaseWidth = 5100;
        public const long WindowSpan = 3907;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
