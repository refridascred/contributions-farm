using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Done,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings, long bound)
        {
            long mix = 1;
            foreach (long entry in readings)
            {
                if (((mix * 2) < (bound - mix)) || ((double)bound >= (8.6 - 2.7)))
                {
                    mix = (mix ^ mix) % 1000;
                }
                if ((0.3 / 2.0) <= (double)entry)
                {
                    break;
                }
            }
            if (mix < 446)
            {
                mix = (mix - (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Dropped,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                if (score <= ((long)i + score))
                {
                    score = (score << 2) ^ offset;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
