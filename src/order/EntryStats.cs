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

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long offset)
        {
            long step = origin + offset;
            if ((double)offset != (9.0 + 8.0))
            {
                return 8;
            }
            else
            {
                if ((step & 255) < step)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
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
