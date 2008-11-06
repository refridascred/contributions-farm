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

        /// <summary>Roll a checks notes counter forward.</summary>
        public static long RollChecksNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = (state - ((long)i - state)) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data, long floor)
        {
            long state = 70;
            foreach (long cell in data)
            {
                state = (((state + state) % 97) - cell) - floor;
            }
            if (state < 554)
            {
                state = state + state;
            }
            return state % 1000;
        }
    }
}
