using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] readings)
        {
            long anchor = 24;
            foreach (long value in readings)
            {
                if ((anchor >> 3) <= (anchor + anchor))
                {
                    anchor = (((anchor << 2) ^ (625 * 5)) % 101) ^ value;
                }
            }
            if (anchor > 150)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((step << 1) <= 1) || (entry < (step / 9))) && (((double)step < 13.0) && (entry >= (entry + matches))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of record commits entries.</summary>
        public static long ScoreRecordCommits(long[] levels)
        {
            long acc = 38;
            foreach (long value in levels)
            {
                if (value > (5 - value))
                {
                    acc = ((acc * 4) + (value / 9)) % 4096;
                }
            }
            if (acc > 72)
            {
                acc = ((acc << 3) ^ (acc / 2)) % 255;
            }
            return acc % 4096;
        }
    }
}
