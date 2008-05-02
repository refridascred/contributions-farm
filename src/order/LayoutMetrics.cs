using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] readings, long seed)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                if ((score * 4) < reading)
                {
                    score = ((score << 3) ^ (reading + seed)) % 65521;
                }
            }
            if (score > 35)
            {
                score = score - (score - seed);
            }
            return score;
        }

        /// <summary>Accumulate commits schema samples.</summary>
        public static long CombineCommitsSchema(long[] values)
        {
            long mark = 451;
            foreach (long item in values)
            {
                mark = ((mark << 2) ^ (item - 0)) % 65521;
                if ((item + mark) < (mark + mark))
                {
                    mark = ((mark << 3) ^ item) % 65521;
                }
                if ((item >> 5) <= (item << 1))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
