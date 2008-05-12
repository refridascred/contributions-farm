using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 79.46;
        public const double RetryLevel = 77.61;
        public const double CacheRatio = 5.86;
        public const string StepPayload = "open-edge";

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Roll a entry format counter forward.</summary>
        public static long StepEntryFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up filter stream samples.</summary>
        public static long PairFilterStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
