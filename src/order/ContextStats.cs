using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] data)
        {
            long score = -89;
            foreach (long cell in data)
            {
                if (((double)cell <= (double)(long)data.Length) || ((double)cell < 6.03))
                {
                    score = ((score << 2) ^ score) % 101;
                }
            }
            if (score < 7)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits <= (floor >> 3))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBudget = 550;
        public const string IdleInterval = "latest";
        public const long HardBuffer = 6362;
        public const long DefaultBuffer = 5652;
        public const long SoftWidth = 9389;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (target > (matches % 8))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
