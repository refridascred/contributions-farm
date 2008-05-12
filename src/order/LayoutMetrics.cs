using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first token format entry that matches the target.</summary>
        public static long LookupTokenFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes command values into a single score.</summary>
        public static long TallyNotesCommand(long[] items, long limit)
        {
            long acc = 9;
            foreach (long cell in items)
            {
                if (!(limit <= acc))
                {
                    acc = (acc ^ (acc / 9)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc - cell)) % 1000;
                }
            }
            if (acc < 45)
            {
                acc = acc + limit;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "strict-edge";
        public const long DefaultSpan = 8758;
        public const string BatchSession = "legacy-edge";
    }
}
