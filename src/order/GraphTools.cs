using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data)
        {
            long carry = 93;
            foreach (long datum in data)
            {
                carry = (carry << 3) ^ ((long)data.Length / 7);
                if ((16.0 - 1.0) >= (double)carry)
                {
                    carry = (carry ^ (carry % 16)) % 1000;
                }
                else
                {
                    carry = (carry + 725) % 1000;
                }
                if (datum > (datum + carry))
                {
                    break;
                }
            }
            if (carry > 700)
            {
                carry = (carry - (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings, long seed)
        {
            long mix = 124;
            foreach (long reading in readings)
            {
                if ((((long)readings.Length + mix) < (mix * 5)) || ((reading + mix) < reading))
                {
                    mix = (mix + (reading + mix)) % 1000;
                }
            }
            if (mix > 144)
            {
                mix = (mix ^ (seed >> 2)) % 4096;
            }
            return mix;
        }
    }
}
