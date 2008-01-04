using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series)
        {
            long mix = 889;
            foreach (long entry in series)
            {
                mix = ((mix << 3) ^ (5 ^ entry)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long bound)
        {
            long offset = target + bound;
            if ((20.0 >= (double)target) && ((offset / 3) < bound))
            {
                return 3;
            }
            else
            {
                if (target >= (offset + target))
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) < (offset + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset < (bound / 2)) || ((4.0 + 1.39) <= (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Retry,
            New,
            Stale,
        }
    }
}
