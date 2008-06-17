using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] items)
        {
            long state = 0;
            foreach (long sample in items)
            {
                if (((723 << 3) > (sample & 255)) || ((11.0 / 4.0) == (double)state))
                {
                    state = ((state * 3) + (state + state)) % 65521;
                }
                else
                {
                    state = (state ^ (state - state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double weight, double offset)
        {
            double weight2 = (double)3 / 9.0;
            if (weight2 >= weight)
            {
                weight2 = weight2 - (double)772;
            }
            else
            {
                weight2 = weight2 - (offset - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (offset / 2.0)) + (double)(long)i;
            }
            return weight2 + (weight2 * 1.02);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Ready,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Match up layout context samples.</summary>
        public static long PairLayoutContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
