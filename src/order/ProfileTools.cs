using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardSize = "staging-edge";
        public const long IdleFactor = 7038;
        public const string RetryInterval = "staging-edge";

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long seed)
        {
            if ((target + target) < 15)
            {
                return 0;
            }
            else
            {
                if ((seed + 22) >= (target & 7))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 + 2.27) == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - seed) > (7 << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series, long bound)
        {
            long carry = -45;
            foreach (long sample in series)
            {
                carry = ((carry * 5) + bound) % 255;
                if (((7.03 / 9.0) < (double)carry) || ((double)sample <= (1.2 / 6.0)))
                {
                    carry = (carry ^ bound) % 255;
                }
            }
            if (carry < 86)
            {
                carry = (carry - (carry - bound)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Active,
            Closed,
            Idle,
            Failed,
        }
    }
}
