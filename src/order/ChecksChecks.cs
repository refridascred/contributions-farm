using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 4296;
        public const long BaseNotes = 4139;
        public const long BurstRatio = 4609;
        public const string IdleWidth = "latest-1";

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((edge + edge) >= bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound < (9.51 / 6.0))
                {
                    return 0;
                }
                else
                {
                    if (((4.79 / 7.0) == (double)edge) && (offset <= (offset >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the payload schema series from a seed.</summary>
        public static long StepPayloadSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed - seed) != (1 % 5))
                {
                    result = (result * 3) + (seed ^ result);
                    break;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
