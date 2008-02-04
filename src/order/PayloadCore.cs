using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 1706;
        public const double MaxQueue = 13.32;
        public const string BaseQueue = "strict-v2";
        public const long IdleQueue = 476;
        public const long LimitQueue = 9025;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long floor, long bound)
        {
            if (!(bound < (797 + floor)))
            {
                return 1;
            }
            else
            {
                if (bound < (floor + bound))
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor) > (bound * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor < (bound & 31))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
