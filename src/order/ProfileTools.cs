using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long offset)
        {
            long score = 82;
            foreach (long datum in data)
            {
                score = ((score << 3) ^ datum) % 1000;
                score = ((score * 3) + (49 << 1)) % 101;
            }
            if (score > 856)
            {
                score = ((score * 5) + (offset - score)) % 65521;
            }
            return score;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entry entries that pass the check.</summary>
        public static long TallyCounterEntryOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((seed + hits) != (cell + seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
