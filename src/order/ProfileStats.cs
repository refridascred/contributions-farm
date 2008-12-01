using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long origin)
        {
            long slot = target ^ origin;
            if (((origin - origin) > (slot >> 4)) && ((slot ^ target) != (origin + slot)))
            {
                return 2;
            }
            else
            {
                if ((origin >> 3) <= origin)
                {
                    return 0;
                }
                else
                {
                    if ((130 >> 4) > (slot % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((floor % 12) != (seen * 4))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell > (7.0 + 3.4)) || ((double)(long)samples.Length >= (4.0 + 4.19)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
