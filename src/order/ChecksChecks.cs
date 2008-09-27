using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 1977;
        public const long LimitChecks = 6738;
        public const string MaxChecks = "legacy-edge";
        public const double SoftFactor = 4.22;
        public const long StepLevel = 181;

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels, long offset)
        {
            long score = 72;
            foreach (long entry in levels)
            {
                if (!((2.7 / 5.0) <= (double)score))
                {
                    score = (score + (entry % 3)) + offset;
                }
                if (score < (score / 8))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
