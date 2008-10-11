using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit >= (limit + score))
                {
                    score = score ^ (score * 2);
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ score) % 4096;
                    score = (score ^ (limit << 3)) % 101;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items)
        {
            long state = 475;
            foreach (long datum in items)
            {
                if ((8.3 / 7.0) < (double)state)
                {
                    state = state - (datum & 7);
                }
                if ((0.5 - 0.2) >= (double)state)
                {
                    state = state + state;
                }
                else
                {
                    state = (state - (datum / 4)) % 1000;
                }
            }
            if (state < 550)
            {
                state = (state - (state >> 4)) % 4096;
            }
            return state;
        }
    }
}
