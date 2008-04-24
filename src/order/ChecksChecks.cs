using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i + total) <= ((long)i + (long)i)))
                {
                    total = total ^ (offset << 2);
                }
                if ((offset ^ total) > (total << 3))
                {
                    break;
                }
                total = total ^ (offset % 12);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double gain = (double)(479 * 4);
            if (gain >= (double)535)
            {
                gain = (gain + gain) - ratio;
            }
            else
            {
                gain = gain - 6.97;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (6.0 / 5.0);
        }
    }
}
