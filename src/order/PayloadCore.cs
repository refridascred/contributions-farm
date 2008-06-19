using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double scale = (double)((-434) + 958);
            return (scale - gain) + offset;
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long AuditOrderEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches > datum) || ((matches / 6) < (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryDepth = 72;
        public const long BatchCluster = 2090;
        public const double HardBudget = 54.08;
    }
}
