using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long score = 51;
            foreach (long sample in readings)
            {
                if ((score & 3) < (sample & 1))
                {
                    score = ((score << 2) ^ (54 - sample)) % 97;
                }
                score = (score ^ (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((double)bound >= 3.0)
                {
                    sum = ((sum << 3) ^ (sum >> 3)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
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
