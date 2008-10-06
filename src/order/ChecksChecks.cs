using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] items)
        {
            long score = 55;
            foreach (long entry in items)
            {
                if ((entry + entry) >= entry)
                {
                    score = (score - (12 >> 3)) % 1000;
                }
                score = score - (score >> 4);
                score = (score << 3) ^ (score + entry);
            }
            if (score > 791)
            {
                score = (score ^ (576 % 7)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Done,
            Active,
            Paused,
        }

        /// <summary>Find the first route profile entry that matches the target.</summary>
        public static long FindRouteProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
