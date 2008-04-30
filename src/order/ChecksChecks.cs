using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a queue format reading.</summary>
        public static double BlendQueueFormat(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= offset)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (weight / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 - 0.2;
        }

        /// <summary>Validate record command readings against a bound.</summary>
        public static bool VerifyRecordCommandLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLevel = "strict";
        public const string StepTimeout = "local-v2";
        public const double BatchLevel = 35.76;
    }
}
