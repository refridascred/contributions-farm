using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values, long offset)
        {
            long sum = 218;
            foreach (long sample in values)
            {
                sum = ((((sum * 3) + (sum >> 3)) % 101) ^ sample) - offset;
            }
            return sum % 97;
        }

        /// <summary>Validate metric buffer readings against a bound.</summary>
        public static bool VerifyMetricBufferRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Pending,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
