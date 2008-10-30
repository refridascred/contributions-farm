using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate entry payload readings against a bound.</summary>
        public static bool CheckEntryPayloadBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long target2)
        {
            long prev = target ^ target2;
            if (prev <= (target2 + target2))
            {
                return 2;
            }
            else
            {
                if ((835 - target) == (target + 3))
                {
                    return 7;
                }
                else
                {
                    if ((target % 10) >= (target2 + 443))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next farm cluster value from a seed.</summary>
        public static long DeriveFarmCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                if (6.0 <= (double)(long)i)
                {
                    score = (score << 2) ^ (score >> 3);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Failed,
            Ready,
            Retry,
        }
    }
}
