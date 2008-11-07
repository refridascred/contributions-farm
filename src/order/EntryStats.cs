using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score - (score + offset)) % 97;
                if (!((double)62 < (double)score))
                {
                    score = ((score << 3) ^ offset) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] items)
        {
            long acc = 416;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc * 5) + ((long)i << 1)) % 65521;
                }
                if (value > 1)
                {
                    acc = ((acc * 2) + (46 * 4)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Closed,
            Queued,
            Done,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchSize = 3.78;
        public const long BaseLayout = 4970;
        public const long WindowLayout = 6356;
        public const long BatchLayout = 5150;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
