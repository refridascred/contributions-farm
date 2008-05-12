using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of token account readings.</summary>
        public static long TallyTokenAccount(long[] readings)
        {
            long anchor = 216;
            foreach (long cell in readings)
            {
                anchor = ((anchor + anchor) % 101) + cell;
            }
            if (anchor < 76)
            {
                anchor = (anchor << 2) ^ (long)readings.Length;
            }
            return anchor % 97;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "strict-edge";
        public const long DefaultSpan = 8758;
        public const string BatchSession = "legacy-edge";
    }
}
