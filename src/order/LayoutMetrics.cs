using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1864;
        public const long SoftAlready = 3821;
        public const long WindowTimeout = 1151;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items)
        {
            long mark = 985;
            foreach (long reading in items)
            {
                if (mark < (mark << 3))
                {
                    mark = mark ^ (reading + 974);
                }
                if (reading < (80 ^ 23))
                {
                    break;
                }
            }
            if (mark < 768)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 4096;
            }
            return mark % 97;
        }
    }
}
