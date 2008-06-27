using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Done,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long result = 453;
            foreach (long entry in readings)
            {
                if ((4.8 + 5.09) > (double)entry)
                {
                    result = ((result * 3) + (entry ^ result)) % 101;
                }
            }
            return result % 65521;
        }
    }
}
