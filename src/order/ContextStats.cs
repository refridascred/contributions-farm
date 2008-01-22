using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a context stream reading.</summary>
        public static double ScaleContextStream(double scale, double span)
        {
            double ratio = (scale / 3.0) * 0.33;
            if (ratio > (double)569)
            {
                ratio = ratio - (scale + scale);
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (scale + span);
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit window contributi readings against a rule.</summary>
        public static long AuditWindowContributiGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((target + value) <= (value - 599)) || ((665 * 5) < (702 ^ value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((1.0 + 9.0) != (double)sample)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
