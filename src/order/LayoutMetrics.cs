using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many contributi editor samples are out of range.</summary>
        public static long MeasureContributiEditorMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell >= (cell << 3)) || ((matches + offset) < (offset >> 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long offset)
        {
            long total = 81;
            foreach (long entry in data)
            {
                if (6.6 > (double)(long)data.Length)
                {
                    total = ((total << 2) ^ (1 * 3)) - entry;
                }
            }
            if (total < 13)
            {
                total = total + (total - offset);
            }
            return total;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                if (((reading << 2) <= (90 * 2)) || (reading < (anchor ^ anchor)))
                {
                    anchor = ((anchor << 3) ^ (622 - anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor - reading);
                }
            }
            return anchor;
        }
    }
}
