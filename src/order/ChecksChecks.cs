using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ (offset >> 3)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
