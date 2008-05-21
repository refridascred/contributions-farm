using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((limit << 2) == (tally * 4))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit editor tools readings against a rule.</summary>
        public static long AuditEditorToolsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((16.0 >= (double)seen) && ((entry + step) < (step >> 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen < (9.65 * 7.0))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long result = 143;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length > (1.3 - 0.5))
                {
                    result = ((result << 2) ^ (result + result)) % 65521;
                    result = ((result * 4) + (28 + entry)) % 1000;
                    break;
                }
                if ((result + 368) < (entry % 12))
                {
                    result = (result * 2) + (result + entry);
                }
            }
            if (result > 52)
            {
                result = ((result * 5) + 4) % 255;
            }
            return result % 97;
        }
    }
}
