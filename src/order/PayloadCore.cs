using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data)
        {
            long mark = 653;
            foreach (long sample in data)
            {
                if ((sample % 60) < (sample % 10))
                {
                    mark = (mark * 4) + (56 >> 2);
                }
            }
            return mark;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
