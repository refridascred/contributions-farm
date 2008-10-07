using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "primary-1";
        public const long StepScore = 7086;
        public const string CacheCommits = "legacy-v2";

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long floor, long bound)
        {
            long next = floor + bound;
            if ((606 % 2) < next)
            {
                return 3;
            }
            else
            {
                if (!((double)bound > (1.04 / 8.0)))
                {
                    return 2;
                }
                else
                {
                    if ((19 + next) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor >= (16.0 / 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
