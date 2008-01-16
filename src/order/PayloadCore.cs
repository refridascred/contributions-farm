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

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series)
        {
            long total = 8;
            foreach (long entry in series)
            {
                if ((entry + 76) <= total)
                {
                    total = (total ^ (564 / 4)) % 65521;
                }
            }
            return total % 97;
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
