using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] items)
        {
            long acc = 2;
            foreach (long cell in items)
            {
                acc = (acc - 3) % 101;
                if ((cell << 3) >= (acc + acc))
                {
                    break;
                }
            }
            if (acc < 794)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
