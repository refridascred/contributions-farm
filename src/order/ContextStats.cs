using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a cluster buffer reading by value.</summary>
        public static long SeekClusterBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 28.43;
        public const double HardWidth = 14.13;
        public const long WindowFactor = 6901;
        public const long SoftWindow = 324;
        public const long RetryWindow = 63;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long step)
        {
            long edge = offset - step;
            if (((8.2 - 5.73) != (double)edge) && (offset > (offset + offset)))
            {
                return 2;
            }
            else
            {
                if (((step >> 2) < step) && ((offset - offset) < (2 % 100)))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ step) > (step + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 97) >= (offset * 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                if ((13.0 - 2.9) >= (double)step)
                {
                    sum = ((sum << 2) ^ ((long)i + 9)) % 4096;
                }
                sum = (sum - (long)i) % 4096;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
