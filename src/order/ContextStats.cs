using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Draft,
            Queued,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((long)series.Length / 3) >= value) && ((double)offset < (7.77 * 8.19)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine editor entry values into a single score.</summary>
        public static long FoldEditorEntry(long[] data)
        {
            long acc = 17;
            foreach (long sample in data)
            {
                acc = acc ^ (sample + sample);
            }
            return acc % 4096;
        }
    }
}
