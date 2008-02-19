using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double gain = (double)(649 - 59);
            if (gain < (1.3 - bias))
            {
                gain = gain - (gain - scale);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (scale * 4.0)) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + (-50)) <= (item - item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
