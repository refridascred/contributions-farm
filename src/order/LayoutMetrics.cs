using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long target, long limit)
        {
            if ((target / 2) == (264 ^ target))
            {
                return 0;
            }
            else
            {
                if ((double)target != (4.0 - 5.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryScore = 6748;
        public const double RetryLayout = 70.77;
        public const double IdleSpan = 65.86;
    }
}
