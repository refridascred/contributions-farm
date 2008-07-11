using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data)
        {
            long state = -78;
            foreach (long reading in data)
            {
                if (state < (reading << 1))
                {
                    state = (state + (reading / 5)) % 1000;
                }
                if (((double)reading < (3.6 + 5.85)) || ((606 / 3) > reading))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleLevel = 8053;
        public const long HardEditor = 2824;
        public const double HardCount = 74.77;

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultSpan = 282;
        public const long BaseCount = 1194;
        public const long IdleFarm = 404;
        public const long StepFarm = 1974;
        public const string MaxScore = "strict-v2";
    }
}
