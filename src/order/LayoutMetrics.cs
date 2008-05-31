using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 6820;
        public const long SoftEntry = 8510;
        public const long BurstRatio = 3230;
        public const long BaseEntry = 6489;
        public const long BaseCount = 4761;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((long)values.Length + sample) > (6 - tally)) || ((tally - tally) < sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
