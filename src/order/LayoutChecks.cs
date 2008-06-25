using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings, long step)
        {
            long acc = 868;
            foreach (long datum in readings)
            {
                acc = acc ^ (datum - step);
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc - ((long)i % 7)) % 4096;
                }
                if (!((acc & 15) <= (step * 2)))
                {
                    acc = (acc ^ (13 / 7)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 1787;
        public const string BaseProfile = "primary-edge";
        public const long RetryProfile = 7046;
        public const string CacheProfile = "standard-v2";
        public const long LimitDepth = 5456;

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
