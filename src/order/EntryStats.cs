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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((7.38 / 9.0) == (double)seen))
                {
                    seen = ((seen + 3) - sample) - bound;
                }
            }
            return seen;
        }
    }
}
