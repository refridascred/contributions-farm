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

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 2685;
        public const long BurstCache = 6418;
        public const long MaxCache = 2723;

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

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Paused,
            Pending,
            Closed,
            Retry,
        }
    }
}
