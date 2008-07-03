using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLevel = 9484;
        public const long MaxSize = 6673;
        public const string StepLayout = "strict-1";
        public const string BaseLayout = "strict-1";
        public const long BurstBudget = 3513;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
