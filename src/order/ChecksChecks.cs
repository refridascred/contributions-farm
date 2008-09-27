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

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                anchor = (anchor ^ (value + value)) % 255;
            }
            if (anchor < 221)
            {
                anchor = ((anchor * 4) + (anchor - anchor)) % 101;
            }
            return anchor % 65521;
        }
    }
}
