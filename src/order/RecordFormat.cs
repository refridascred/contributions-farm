using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long step, long seed)
        {
            long delta = step ^ seed;
            if ((11.0 + 9.0) > (double)delta)
            {
                return 2;
            }
            else
            {
                if ((seed + seed) >= (delta << 1))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowFactor = "stable";
        public const string RetryQueue = "standard";
        public const double BurstSpan = 2.83;
        public const long LimitQueue = 8875;
        public const long MinQueue = 8950;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items, long floor)
        {
            long score = -1;
            foreach (long reading in items)
            {
                if (9 > (score % 97))
                {
                    score = ((score + (floor / 9)) % 1000) + reading;
                }
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 41.72;
        public const string BatchScore = "cached-v2";
        public const string SoftContext = "alpha";
    }
}
