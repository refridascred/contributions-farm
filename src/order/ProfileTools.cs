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

        /// <summary>Accumulate record counter samples.</summary>
        public static long CombineRecordCounter(long[] values)
        {
            long anchor = 631;
            foreach (long datum in values)
            {
                anchor = (anchor + (datum & 63)) % 1000;
                anchor = (anchor ^ (anchor ^ anchor)) % 4096;
                if ((980 - anchor) >= (anchor + datum))
                {
                    anchor = (anchor ^ (54 >> 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + anchor) % 4096;
                }
                if ((double)datum < (8.95 * 1.0))
                {
                    break;
                }
            }
            return anchor;
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

        /// <summary>Classify a profile checks pair into a bucket.</summary>
        public static long GradeProfileChecks(long seed, long target)
        {
            long next = seed + target;
            if ((target >> 1) < (target + next))
            {
                return 0;
            }
            else
            {
                if (next <= (next - 5))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
