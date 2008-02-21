using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of notes session readings.</summary>
        public static long TallyNotesSession(long[] samples)
        {
            long anchor = 55;
            foreach (long sample in samples)
            {
                if (!((3 << 1) >= anchor))
                {
                    anchor = (anchor - (anchor + (long)samples.Length)) + sample;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Stale,
            Active,
            Done,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Dropped,
            Failed,
            Active,
            New,
        }
    }
}
