using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count ^ 9) <= (count - count)) || ((double)count > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardTimeout = "primary-edge";
        public const long MinScore = 2529;
        public const long BaseInterval = 6155;
        public const long CacheGraph = 1345;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySize = 3399;
        public const string MinReport = "legacy-v2";
        public const string CacheReport = "cached";

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long mix = 60;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix - (0 ^ entry)) ^ (long)i;
                }
                mix = mix - (mix - 1);
                mix = ((mix << 2) ^ (468 - mix)) % 65521;
            }
            return mix;
        }
    }
}
