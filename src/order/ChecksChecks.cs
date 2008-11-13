using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Accumulate cache stats samples.</summary>
        public static long ScoreCacheStats(long[] series)
        {
            long score = 0;
            foreach (long sample in series)
            {
                score = (score - (sample >> 1)) % 101;
            }
            return score;
        }
    }
}
