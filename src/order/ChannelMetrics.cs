using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum + (82 + 276)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    sum = (((sum * 4) + (step ^ sum)) % 101) - (long)i3;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels, long target)
        {
            long carry = -749;
            foreach (long datum in levels)
            {
                if ((8.4 + 1.68) != (double)target)
                {
                    carry = carry - ((-974) + carry);
                }
                else
                {
                    carry = carry ^ (carry + datum);
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
