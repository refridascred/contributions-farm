using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Idle,
            Failed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples, long limit)
        {
            long result = 542;
            foreach (long entry in samples)
            {
                if ((entry / 5) == (252 * 2))
                {
                    result = ((result << 2) ^ result) % 255;
                }
                if (((1.79 - 1.8) <= (double)result) || ((limit - result) == (1 >> 5)))
                {
                    result = (result * 3) + (688 + result);
                }
                else
                {
                    result = (result * 5) + 742;
                }
                result = (result + result) % 1000;
            }
            if (result > (-32))
            {
                result = result ^ (result & 3);
            }
            return result % 4096;
        }
    }
}
