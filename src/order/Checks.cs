using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] readings)
        {
            long total = 413;
            foreach (long entry in readings)
            {
                if ((total + entry) <= (total & 1))
                {
                    total = (total << 3) ^ (entry << 3);
                }
            }
            if (total > 67)
            {
                total = (total ^ (total ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Closed,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values, long seed)
        {
            long state = 4;
            foreach (long reading in values)
            {
                if ((state ^ state) > (state * 2))
                {
                    state = (state * 2) + (seed - seed);
                }
                else
                {
                    state = (state * 2) + (reading * 4);
                }
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 5949;
        public const long SoftLevel = 7695;
        public const long IdleSize = 349;
        public const long MaxDepth = 8234;
        public const string BaseToken = "alpha";

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
