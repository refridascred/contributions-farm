using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 758;
        public const string BaseSize = "local-1";
        public const long HardTimeout = 8618;
        public const long MaxRatio = 3612;
        public const string IdleSize = "local";

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double span)
        {
            double ratio = (double)(6 % 64);
            if (ratio < gain)
            {
                ratio = ratio - (gain * 3.6);
            }
            else
            {
                ratio = ratio - gain;
            }
            return ratio + (ratio + span);
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long offset, long offset2)
        {
            long edge = offset - offset2;
            if (((offset - offset2) >= (offset2 & 7)) && ((double)edge < 8.96))
            {
                return 1;
            }
            else
            {
                if ((offset2 + offset2) <= offset)
                {
                    return 2;
                }
                else
                {
                    if (!((offset + edge) > (offset % 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset < (edge + offset2)) && ((20.0 / 9.0) == (double)offset))
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
        }
    }
}
