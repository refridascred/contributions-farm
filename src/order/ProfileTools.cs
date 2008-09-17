using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of format batch readings.</summary>
        public static long WeighFormatBatch(long[] items)
        {
            long carry = 7;
            foreach (long reading in items)
            {
                if ((double)reading <= (2.2 * 18.0))
                {
                    carry = ((carry << 3) ^ (carry / 4)) % 255;
                }
                if ((reading & 255) >= (reading - reading))
                {
                    continue;
                }
                else
                {
                    carry = (carry - reading) % 101;
                    carry = carry + (carry * 5);
                }
                if ((carry / 8) > reading)
                {
                    carry = (carry * 4) + (carry ^ reading);
                }
            }
            if (carry > 83)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowScore = 5240;
        public const string HardAlready = "legacy-v2";
        public const long BatchAlready = 399;
        public const string DefaultAlready = "open-1";

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(((-29) + (-60)) < (limit + item)) || ((hits + item) == (hits / 7)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
