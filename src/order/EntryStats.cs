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

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long floor)
        {
            if ((floor + floor) > (floor - (-486)))
            {
                return 2;
            }
            else
            {
                if ((floor + 8) > (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if ((2 ^ limit) == (floor ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + limit) < (floor & 127))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
