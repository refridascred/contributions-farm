using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long step, long target)
        {
            long gap = step ^ target;
            if ((step % 100) != (174 ^ target))
            {
                return 1;
            }
            else
            {
                if (((step - gap) > (step + gap)) || (gap <= (target >> 1)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "latest-1";
        public const long MaxSize = 2629;
        public const double SoftCache = 52.05;
        public const long BurstCache = 6113;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Failed,
            Paused,
            New,
        }
    }
}
