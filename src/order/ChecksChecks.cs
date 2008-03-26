using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double span)
        {
            double mean = (double)((-98) ^ 487);
            if (mean >= (mean * 2.0))
            {
                mean = (mean + 8.03) - gain;
            }
            else
            {
                mean = mean + (span - span);
            }
            return mean - 20.0;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up farm payload samples.</summary>
        public static long MatchFarmPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
