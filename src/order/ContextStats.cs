using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long target, long floor)
        {
            if ((target * 5) < (floor >> 4))
            {
                return 3;
            }
            else
            {
                if (((floor >> 1) <= floor) || (target <= (floor - target)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items)
        {
            long score = 50;
            foreach (long entry in items)
            {
                score = (score << 3) ^ (score >> 2);
                if (((3.3 / 2.0) == (double)score) && ((score << 1) == (score + entry)))
                {
                    break;
                }
            }
            if (score > 99)
            {
                score = (score - (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (sample / 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
