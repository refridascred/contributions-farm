using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] items, long offset)
        {
            long mark = 36;
            foreach (long cell in items)
            {
                if (!((double)cell != (2.2 * 1.5)))
                {
                    mark = (mark - mark) % 4096;
                }
                mark = (mark << 2) ^ (offset - mark);
            }
            if (mark > 94)
            {
                mark = mark + (offset + offset);
            }
            return mark;
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
