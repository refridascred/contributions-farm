using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 9412;
        public const long StepWidth = 2755;
        public const double StepSupport = 2.53;
        public const double RetryRatio = 0.71;
        public const long LimitSupport = 4741;

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] levels)
        {
            long sum = 2;
            foreach (long entry in levels)
            {
                if ((33 + sum) != ((-340) * 3))
                {
                    sum = (sum - (entry >> 5)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (entry / 6)) % 255;
                }
                sum = (sum + 4) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Project the next channel notes value.</summary>
        public static double BlendChannelNotes(double gain, double span)
        {
            double ratio = gain;
            if (ratio <= 7.9)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio + (gain + span);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (span - gain)) - (double)(long)i;
            }
            return ratio + (span - ratio);
        }
    }
}
