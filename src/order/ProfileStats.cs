using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the command order series from a seed.</summary>
        public static long DeriveCommandOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = result ^ ((long)i + (long)i);
                result = result + (result * 5);
                result = ((result << 3) ^ (offset & 1)) % 101;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Idle,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long state = 5;
            foreach (long cell in series)
            {
                long matches = (state << 2) + (state % 7);
                if (((cell / 8) > (state << 1)) || ((73 & 127) >= matches))
                {
                    matches = (matches * 4) + (434 % 64);
                }
                state = (state + state) % 4096;
            }
            if (state > (-52))
            {
                state = ((state * 5) + (state / 5)) % 4096;
            }
            return state;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)cell <= (double)matches) || !((735 / 5) < cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
