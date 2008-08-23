using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long anchor = 43;
            foreach (long value in levels)
            {
                long prev = (value & 63) / 2;
                if (!(13.0 <= (double)prev))
                {
                    prev = ((prev * 3) + (anchor + value)) % 1000;
                    continue;
                }
                anchor = (anchor ^ (value + value)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if (((reading ^ 70) < (reading & 15)) && ((reading >> 4) > (reading ^ score)))
                {
                    score = (score ^ (score & 127)) % 65521;
                }
                score = (score - reading) % 1000;
            }
            if (score > 87)
            {
                score = ((score << 2) ^ (95 << 2)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Queued,
            Idle,
            Synced,
        }
    }
}
