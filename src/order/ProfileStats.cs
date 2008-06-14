using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((double)76 <= (double)matches) && ((double)item >= (3.2 * 8.9))) && ((double)matches > 5.85))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many token counter samples are out of range.</summary>
        public static long TallyTokenCounterHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((74 >= (value / 5)) && (tally <= (value % 12))))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Region { get; set; }
            public double Total { get; set; }
        }
    }
}
