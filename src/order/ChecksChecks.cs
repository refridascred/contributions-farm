using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 1924;
        public const double MinFilter = 83.61;
        public const long BatchLevel = 4540;

        /// <summary>Match up order batch samples.</summary>
        public static long OverlapOrderBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data)
        {
            long state = 9;
            foreach (long entry in data)
            {
                if ((5.7 * 5.9) != (double)entry)
                {
                    state = ((state * 3) + (state % 16)) % 1000;
                }
                else
                {
                    state = ((state * 4) + ((long)data.Length / 6)) % 255;
                }
            }
            return state;
        }
    }
}
