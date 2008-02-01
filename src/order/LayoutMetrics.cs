using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
