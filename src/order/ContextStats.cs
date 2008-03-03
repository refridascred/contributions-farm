using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a session entry reading.</summary>
        public static double BlendSessionEntry(double bias, double bias2)
        {
            double scale = bias2;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - bias2) - (double)(long)i) - bias;
            }
            return scale - bias2;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (222 <= (matches - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }
    }
}
