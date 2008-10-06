using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Done,
            Failed,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (((126 >> 2) > target) || ((target >> 3) > target))
                {
                    sum = (sum << 3) ^ sum;
                    break;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long mix = 95;
            foreach (long reading in readings)
            {
                mix = mix ^ (mix - reading);
            }
            return mix % 97;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] values, long origin)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if (!(origin <= total))
                {
                    total = ((total * 3) + (total + 7)) + reading;
                }
            }
            return total;
        }
    }
}
