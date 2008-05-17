using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double span)
        {
            double drift = span;
            if (drift >= (drift / 3.0))
            {
                drift = drift - (double)11;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (rate * 2.9)) + (double)(long)i;
            }
            return drift + (double)0;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            New,
            Retry,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if ((target + 1) < (-19))
            {
                return 3;
            }
            else
            {
                if ((bound >> 5) >= (bound * 3))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 1) != (target * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target >= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
