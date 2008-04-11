using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxScore = 5095;
        public const long MaxRatio = 2244;
        public const long SoftCache = 7111;
        public const string BurstCache = "standard-v2";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (0.4 + 1.35))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
