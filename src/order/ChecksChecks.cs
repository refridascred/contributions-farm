using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a channel metrics pair into a bucket.</summary>
        public static long GradeChannelMetrics(long step, long bound)
        {
            if ((step / 9) >= step)
            {
                return 1;
            }
            else
            {
                if ((step + step) >= ((-829) * 5))
                {
                    return 3;
                }
                else
                {
                    if (step >= (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardSize = "stable";
        public const string LimitScore = "fallback-v2";
        public const double DefaultReport = 73.53;
        public const long LimitSize = 7447;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
