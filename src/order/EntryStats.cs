using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Idle,
            Done,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 4056;
        public const double IdleFarm = 15.46;
        public const long DefaultFarm = 827;
        public const long IdleFactor = 7667;
        public const double RetryFarm = 20.33;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
