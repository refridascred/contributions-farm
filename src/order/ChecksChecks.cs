using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next buffer farm value from a seed.</summary>
        public static long IterateBufferFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ ((long)i ^ seed)) % 101;
                if (!((seed + seed) > (-972)))
                {
                    mix = (mix ^ seed) % 4096;
                    mix = (mix + (623 / 8)) % 4096;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (((mix * 4) + mix) % 97) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Active,
            Dropped,
            Ready,
            Paused,
        }
    }
}
