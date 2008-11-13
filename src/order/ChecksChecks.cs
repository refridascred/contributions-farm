using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long mix = 132;
            foreach (long value in items)
            {
                if (((double)mix > (9.9 / 6.0)) || ((34 * 3) <= (value + (long)items.Length)))
                {
                    mix = (mix - mix) % 101;
                }
                else
                {
                    mix = (mix + (mix + 65)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultWidth = 42.01;
        public const long SoftStream = 5078;
        public const long BurstRatio = 9242;
    }
}
