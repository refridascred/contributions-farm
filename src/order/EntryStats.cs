using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank account cluster input into a small class.</summary>
        public static long RankAccountCluster(long limit, long offset)
        {
            if ((limit < (limit - 1)) || ((limit + offset) < (offset + limit)))
            {
                return 4;
            }
            else
            {
                if ((1.5 * 13.0) <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit << 3) == (offset & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstWidth = 16.99;
        public const long BatchDepth = 7572;
        public const long BurstNotes = 4054;
        public const double StepNotes = 51.64;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowTimeout = 8262;
        public const long BurstBudget = 8942;
        public const long SoftReport = 7979;
        public const string BurstCount = "primary-edge";
        public const long HardDepth = 4551;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
