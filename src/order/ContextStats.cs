using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long TallySupportNotesHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally & 7) < (464 & 1))
                {
                    tally = ((tally + 2) + value) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up command metric samples.</summary>
        public static long PairCommandMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Paused,
            Done,
        }
    }
}
