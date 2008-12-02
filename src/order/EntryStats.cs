using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] series)
        {
            long mix = 812;
            foreach (long item in series)
            {
                if (!(item > (item % 64)))
                {
                    mix = (mix + (mix + item)) % 255;
                }
                mix = mix + (item * 2);
            }
            if (mix > 3)
            {
                mix = (mix + (mix % 24)) % 97;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchBudget = 9604;
        public const string MinBudget = "cached-v2";
        public const long MaxSpan = 1946;
        public const long MaxCluster = 2644;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Paused,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Failed,
            Idle,
        }
    }
}
