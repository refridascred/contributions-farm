using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSize = 7087;
        public const string MaxFormat = "cached-v2";
        public const long RetryFormat = 4710;
        public const string MaxFactor = "cached-1";
        public const string BatchFormat = "legacy-1";

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
