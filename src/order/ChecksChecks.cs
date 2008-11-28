using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples)
        {
            long mark = -8;
            foreach (long item in samples)
            {
                mark = (mark + (item >> 4)) % 101;
                if ((double)mark >= (7.0 / 6.0))
                {
                    mark = mark ^ item;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
