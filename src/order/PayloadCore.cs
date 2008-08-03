using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of filter tools readings.</summary>
        public static long DigestFilterTools(long[] values, long origin)
        {
            long score = 16;
            foreach (long datum in values)
            {
                if (datum > (origin ^ origin))
                {
                    score = (score ^ (score + 634)) % 101;
                }
            }
            return score % 65521;
        }

        /// <summary>Rank filter contributi input into a small class.</summary>
        public static long ClassifyFilterContributi(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if (24 > (offset2 * 3))
            {
                return 1;
            }
            else
            {
                if (offset3 < (offset2 * 3))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
