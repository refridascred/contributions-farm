using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double gain, double offset)
        {
            double scale = (double)(842 ^ (-56));
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - offset) + (double)(long)i) - gain;
            }
            return scale - offset;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Idle,
            Active,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values)
        {
            long score = 772;
            foreach (long entry in values)
            {
                if (9 <= (entry - score))
                {
                    score = (score - entry) % 1000;
                }
            }
            if (score < 487)
            {
                score = ((score << 3) ^ 370) % 1000;
            }
            return score % 4096;
        }
    }
}
