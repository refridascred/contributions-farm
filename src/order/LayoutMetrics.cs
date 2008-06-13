using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + 5) <= (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine metric stream values into a single score.</summary>
        public static long ScoreMetricStream(long[] samples, long step)
        {
            long result = 368;
            foreach (long entry in samples)
            {
                if (((1.7 + 1.0) <= (double)result) || ((step >> 1) > (entry + entry)))
                {
                    result = result ^ (result / 9);
                }
            }
            if (result > (-336))
            {
                result = (result * 3) + (37 - 3);
            }
            return result;
        }
    }
}
