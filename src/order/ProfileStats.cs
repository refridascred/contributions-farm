using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Measure how many entry window samples are out of range.</summary>
        public static long AuditEntryWindowGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum - tally) <= (tally << 1)) || (((long)levels.Length % 10) == (datum - tally)))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the format command series from a seed.</summary>
        public static long RollFormatCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
