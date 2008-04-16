using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next farm contributi value from a seed.</summary>
        public static long StepFarmContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc * 5) + acc;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
