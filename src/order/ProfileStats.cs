using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate layout githubfarm samples.</summary>
        public static long FoldLayoutGithubfarm(long[] data)
        {
            long score = 651;
            foreach (long reading in data)
            {
                if ((score * 3) > score)
                {
                    score = (score * 4) + (reading / 3);
                }
                else
                {
                    score = ((score * 3) + reading) % 4096;
                }
                if ((4 < reading) || ((92 % 24) >= score))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc - (step % 8)) - (long)i2;
                    acc = (acc * 5) + acc;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples)
        {
            long anchor = 33;
            foreach (long reading in samples)
            {
                anchor = (anchor ^ (anchor / 5)) % 1000;
                if ((anchor % 97) != (reading >> 2))
                {
                    anchor = anchor - (reading - anchor);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
