using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a editor githubfarm reading by value.</summary>
        public static long SeekEditorGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 5963;
        public const double DefaultBudget = 26.64;
        public const long BatchEntry = 9638;

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
