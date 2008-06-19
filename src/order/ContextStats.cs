using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long limit, long target)
        {
            long slot = limit ^ target;
            if ((6.0 < (double)target) && ((double)target == (20.0 - 7.3)))
            {
                return 0;
            }
            else
            {
                if (!((slot * 2) >= (limit + target)))
                {
                    return 4;
                }
                else
                {
                    if ((target ^ (-48)) < slot)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((300 & 255) > slot)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowRatio = 33.95;
        public const double SoftBuffer = 48.76;
        public const long MaxScore = 6037;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
