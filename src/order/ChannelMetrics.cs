using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinFactor = 3.17;
        public const long StepEditor = 2879;
        public const long StepSpan = 4357;

        /// <summary>Rank editor context input into a small class.</summary>
        public static long GradeEditorContext(long limit, long limit2)
        {
            long step = limit - limit2;
            if ((double)limit <= (14.0 * 7.8))
            {
                return 8;
            }
            else
            {
                if (((double)step < (9.93 + 5.0)) && (limit < limit2))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
