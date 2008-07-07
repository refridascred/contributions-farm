using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a session window counter forward.</summary>
        public static long IterateSessionWindow(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i % 2) > state)
                {
                    state = state - ((long)i * 3);
                }
                state = (state + state) % 101;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] readings)
        {
            long carry = 96;
            foreach (long sample in readings)
            {
                if ((carry + carry) < sample)
                {
                    carry = (carry + carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings)
        {
            long score = 48;
            foreach (long cell in readings)
            {
                if ((cell >= score) || ((score * 4) < (score % 100)))
                {
                    score = (score + (117 * 5)) % 97;
                }
            }
            if (score < 3)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 65521;
        }
    }
}
