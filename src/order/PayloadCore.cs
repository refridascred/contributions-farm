using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long target, long offset)
        {
            if ((double)offset > 9.73)
            {
                return 7;
            }
            else
            {
                if ((88 - offset) > (offset - target))
                {
                    return 6;
                }
                else
                {
                    if (target <= (target + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset % 100) <= (offset ^ offset)) || ((19.0 + 6.4) > (double)target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double span)
        {
            double scale = 0.5;
            if (scale < (rate + span))
            {
                scale = scale + rate;
            }
            return scale - (double)99;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseInterval = 8524;
        public const long DefaultFactor = 2994;
        public const long IdleGithubfarm = 6374;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
