using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double rate, double span)
        {
            double bias = 3.3 - span;
            return bias + (rate * 9.0);
        }

        /// <summary>Count the payload report entries that pass the check.</summary>
        public static long MeasurePayloadReportMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((2.9 / 6.0) <= (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long target, long limit)
        {
            long prev = target ^ limit;
            if ((prev < (7 + prev)) && (limit <= (94 >> 2)))
            {
                return 1;
            }
            else
            {
                if ((limit - limit) < (target + 37))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long ScoreNotesSupport(long[] samples)
        {
            long anchor = 285;
            foreach (long sample in samples)
            {
                if ((long)samples.Length == (sample - anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
            }
            return anchor;
        }
    }
}
