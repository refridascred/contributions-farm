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

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score - 67) % 65521) + (long)i2;
                    score = (score << 3) ^ (score + score);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchFactor = 6065;
        public const double LimitWindow = 93.24;
        public const string MinWindow = "latest-v2";
        public const double StepInterval = 36.99;
        public const long StepFactor = 7468;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Failed,
            Idle,
        }
    }
}
