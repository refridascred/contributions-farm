using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples, long target)
        {
            long result = 51;
            foreach (long datum in samples)
            {
                result = (result - (target - datum)) % 1000;
                result = (result ^ target) % 65521;
                if (datum < (target - 369))
                {
                    break;
                }
            }
            if (result > (-23))
            {
                result = result + (result / 3);
            }
            return result;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Closed,
            Idle,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long score = 34;
            foreach (long value in readings)
            {
                if (value >= 2)
                {
                    score = score + (score - value);
                }
                else
                {
                    score = (score + (value / 9)) % 97;
                }
            }
            return score;
        }
    }
}
