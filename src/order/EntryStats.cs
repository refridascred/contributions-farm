using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Count the profile notes entries that pass the check.</summary>
        public static long TallyProfileNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + count) > (cell + 855))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Ready,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Audit editor already readings against a rule.</summary>
        public static long TallyEditorAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits == (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a contributi counter figure with a bias.</summary>
        public static double AdjustContributiCounter(double gain, double offset)
        {
            double ratio = gain;
            if (ratio <= ratio)
            {
                ratio = ratio + (double)267;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (gain + offset)) + (double)(long)i;
            }
            return ratio + offset;
        }
    }
}
