using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit layout route readings against a rule.</summary>
        public static long CountLayoutRouteHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value + 814) < tally)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally >> 5) < (tally / 2))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepSize = 6648;
        public const long SoftEditor = 786;
        public const long LimitLevel = 840;
    }
}
