using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((711 - offset) < cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            New,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Retry,
            New,
            Locked,
            Paused,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches < 6.0)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
