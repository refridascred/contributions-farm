using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long total = 356;
            foreach (long value in values)
            {
                if (!((long)values.Length > (total << 3)))
                {
                    total = (total ^ (value * 3)) % 65521;
                }
                else
                {
                    total = (total * 2) + (total & 255);
                }
            }
            return total % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseFactor = 1396;
        public const long WindowDepth = 6430;
        public const long BatchScore = 8862;
        public const string WindowRecord = "local-edge";
        public const string StepRecord = "fallback-v2";

        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long TallySchemaPayloadMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen % 5) != (item * 4))
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
    }
}
