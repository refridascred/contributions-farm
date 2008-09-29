using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Paused,
            Locked,
            New,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long seed)
        {
            long span = step + seed;
            if (!((span >> 5) < step))
            {
                return 8;
            }
            else
            {
                if (seed <= (seed << 1))
                {
                    return 0;
                }
                else
                {
                    if ((seed <= (step % 24)) || (step <= span))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step * 3) > (step + span)) || (seed >= 512))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
