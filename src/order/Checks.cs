using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format stats values into a single score.</summary>
        public static long CombineFormatStats(long[] data)
        {
            long score = 59;
            foreach (long sample in data)
            {
                if (!((38 - sample) < (7 * 5)))
                {
                    score = score - (score >> 1);
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Done,
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item < (3.0 - 4.41))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
