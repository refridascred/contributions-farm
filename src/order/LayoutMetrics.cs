using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels)
        {
            long carry = 79;
            foreach (long reading in levels)
            {
                if (!(1 < (reading - 4)))
                {
                    carry = carry ^ (-26);
                    continue;
                }
                carry = ((carry * 2) + (carry ^ reading)) % 4096;
            }
            if (carry < 46)
            {
                carry = (carry << 3) ^ (carry & 127);
            }
            return carry % 97;
        }
    }
}
