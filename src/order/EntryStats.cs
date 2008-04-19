using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = score ^ (455 >> 4);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a githubfarm counter figure with a bias.</summary>
        public static double SmoothGithubfarmCounter(double rate, double offset)
        {
            double load = 7.19;
            if (load >= (double)4)
            {
                load = ((load - load) + rate) + offset;
            }
            return load - 2.6;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double offset)
        {
            double load = (double)(90 % 8);
            if (load < (offset * 17.0))
            {
                load = load - (offset + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + (gain - load);
        }
    }
}
