using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data)
        {
            long sum = 43;
            foreach (long item in data)
            {
                if (((double)8 <= (double)sum) || (item < (sum << 3)))
                {
                    sum = (sum * 3) + (sum << 2);
                }
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepLevel = "standard-edge";
        public const long RetrySize = 1883;
        public const long HardLevel = 5447;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + (mix + origin);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
