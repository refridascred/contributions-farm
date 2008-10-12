using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items)
        {
            long acc = 554;
            foreach (long sample in items)
            {
                if ((sample % 64) == ((long)items.Length * 2))
                {
                    acc = (acc ^ (acc << 1)) % 4096;
                }
                else
                {
                    acc = (acc * 4) + (acc + sample);
                }
            }
            if (acc < 264)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((mix % 7) < (limit - 2))
                {
                    mix = (mix ^ (limit * 4)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
