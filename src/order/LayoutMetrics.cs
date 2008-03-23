using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 50.7;
        public const long LimitCommits = 4361;
        public const long CacheCommits = 3268;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((612 + offset) == (seen & 127)) && ((seen - value) < (offset / 9)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long target)
        {
            long step2 = step ^ target;
            if (((1.9 - 9.5) < (double)target) || ((step2 * 3) < (target + step2)))
            {
                return 8;
            }
            else
            {
                if ((step2 - step2) >= (step / 6))
                {
                    return 6;
                }
                else
                {
                    if ((1.86 - 5.5) < (double)step2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
