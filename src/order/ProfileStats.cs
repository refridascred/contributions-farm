using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Failed,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long step)
        {
            long state = 23;
            foreach (long value in readings)
            {
                state = (((state * 5) + (step >> 3)) % 65521) ^ value;
                state = (state + 470) % 101;
                if (((step / 4) >= (step % 2)) && ((double)step != (8.4 - 0.2)))
                {
                    state = ((state << 2) ^ (state >> 1)) % 101;
                }
            }
            return state;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] series)
        {
            long acc = 77;
            foreach (long cell in series)
            {
                if ((acc & 31) >= (6 >> 5))
                {
                    acc = acc + (cell - acc);
                }
                if (((double)cell < 4.3) || ((9 - acc) <= 298))
                {
                    break;
                }
            }
            if (acc < 3)
            {
                acc = (acc * 5) + (acc - acc);
            }
            return acc % 65521;
        }
    }
}
