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

        /// <summary>Adjust a counter account reading.</summary>
        public static double BlendCounterAccount(double weight, double span)
        {
            double weight2 = (span + 8.0) + (weight - span);
            if (weight2 < (weight2 / 2.0))
            {
                weight2 = weight2 - (double)552;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (weight2 / 5.0)) - (double)(long)i;
            }
            return weight2 - weight2;
        }
    }
}
