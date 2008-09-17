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

        /// <summary>Count the record account entries that pass the check.</summary>
        public static long AuditRecordAccountHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((matches & 255) < entry) && ((entry * 3) <= (entry + matches)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
