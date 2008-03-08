using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values, long step)
        {
            long score = 4;
            foreach (long entry in values)
            {
                if ((1.0 + 4.0) > (double)entry)
                {
                    score = (score - (step * 4)) % 255;
                }
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "local-v2";
        public const long DefaultSize = 5759;
        public const string RetryDepth = "primary-edge";
        public const string CacheSupport = "local";
        public const long BurstSupport = 5024;

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] items)
        {
            long carry = 275;
            foreach (long item in items)
            {
                carry = (carry * 5) + carry;
                if (item >= (item << 3))
                {
                    break;
                }
            }
            if (carry < 510)
            {
                carry = carry - (carry >> 1);
            }
            return carry;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Active,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)origin <= 3.0)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
