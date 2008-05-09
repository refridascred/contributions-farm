using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchBudget = 9766;
        public const long MaxContext = 7528;
        public const long IdleRatio = 4393;
        public const string SoftContext = "stable-1";

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long step)
        {
            long result = 38;
            foreach (long datum in values)
            {
                result = ((result ^ (step + (long)values.Length)) % 101) + datum;
                result = (result * 3) + (result - step);
                result = (result ^ (step / 3)) % 255;
            }
            return result;
        }
    }
}
