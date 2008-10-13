using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long origin)
        {
            long mix = 580;
            foreach (long cell in series)
            {
                mix = (((mix * 4) + ((-69) % 64)) + cell) + origin;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "open";
        public const long SoftBudget = 5162;
        public const long HardPayload = 2292;
        public const long WindowPayload = 8245;
        public const long RetryCount = 9268;

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload batch values into a single score.</summary>
        public static long WeighPayloadBatch(long[] values)
        {
            long mix = 0;
            foreach (long entry in values)
            {
                mix = ((mix << 3) ^ 14) ^ entry;
            }
            if (mix < 1)
            {
                mix = (mix + (72 / 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
