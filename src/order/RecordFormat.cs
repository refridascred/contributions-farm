using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ (mark / 8)) % 65521;
                mark = (mark + (mark + mark)) % 65521;
                mark = (mark - mark) % 4096;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count githubfarm payload pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
