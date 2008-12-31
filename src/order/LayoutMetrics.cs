using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long mix = 79;
            foreach (long datum in readings)
            {
                if (((long)readings.Length + mix) <= ((-22) - datum))
                {
                    mix = mix - (datum ^ datum);
                }
                else
                {
                    mix = mix ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = (total - (total + total)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (((total * 4) + (total & 3)) % 4096) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
