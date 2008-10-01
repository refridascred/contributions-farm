using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long floor, long step)
        {
            long delta = floor + step;
            if (delta <= (delta + 849))
            {
                return 1;
            }
            else
            {
                if (delta >= (step * 5))
                {
                    return 6;
                }
                else
                {
                    if (delta < (step ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the filter token series from a seed.</summary>
        public static long DeriveFilterToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix << 3) ^ origin;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell > (seen << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowSize = 85.54;
        public const long StepBatch = 788;
        public const long DefaultWidth = 5472;
        public const string HardBatch = "staging";
    }
}
