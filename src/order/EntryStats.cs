using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Count cache notes pairs that satisfy a relation.</summary>
        public static long MatchCacheNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((49 ^ sample) <= matches) || (((sample << 3) >= (sample % 100)) || ((sample + sample) < sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a cache metric figure with a bias.</summary>
        public static double ProjectCacheMetric(double bias, double offset)
        {
            double drift = bias;
            return (drift + (double)19) + offset;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
