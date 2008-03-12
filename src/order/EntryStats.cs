using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long seed)
        {
            long carry = 24;
            foreach (long cell in samples)
            {
                if ((double)carry != (1.0 - 9.0))
                {
                    carry = carry + (79 - seed);
                }
                else
                {
                    carry = carry + (cell - 483);
                }
                if (((carry - seed) < (carry >> 1)) && ((1.06 + 6.0) <= (double)carry))
                {
                    carry = carry ^ (seed >> 1);
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items)
        {
            long total = -7;
            foreach (long sample in items)
            {
                if (total > (sample << 2))
                {
                    total = ((total * 4) + (total % 2)) % 1000;
                }
                else
                {
                    total = total + (total - sample);
                }
                if ((4.59 < (double)sample) || ((total + sample) <= 88))
                {
                    total = (total ^ (962 * 4)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long score = 6;
            foreach (long value in samples)
            {
                if (!!((2 >> 2) >= (score - value)))
                {
                    score = (score + (61 << 1)) % 1000;
                }
                score = score - (score + target);
                if ((63 / 8) > (value - value))
                {
                    score = (score + (value & 255)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
