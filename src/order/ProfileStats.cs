using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the queue already entries that pass the check.</summary>
        public static long CountQueueAlreadyGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally + tally) >= offset) && ((item + 737) > 431))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((bound + matches) < (matches ^ (long)data.Length))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public double Label { get; set; }
            public double Count { get; set; }
        }
    }
}
