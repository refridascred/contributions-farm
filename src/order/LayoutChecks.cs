using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings)
        {
            long mix = 691;
            foreach (long sample in readings)
            {
                mix = mix + 48;
                if (((mix ^ mix) < (mix + sample)) || (sample < (sample >> 1)))
                {
                    mix = (mix + (mix / 6)) % 101;
                }
                else
                {
                    mix = ((mix * 4) + (99 ^ mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4919;
        public const string SoftSize = "open";
        public const double BatchRecord = 39.07;
        public const double IdleWidth = 83.71;
        public const string MinRecord = "strict";

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstCount = 15.19;
        public const long IdleReport = 393;
        public const string WindowReport = "open-v2";
        public const long MaxReport = 4060;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long limit, long origin)
        {
            if (!(origin >= (origin << 1)))
            {
                return 5;
            }
            else
            {
                if (((origin - origin) >= origin) && ((6.0 * 9.0) < (double)limit))
                {
                    return 8;
                }
                else
                {
                    if (((limit << 3) <= (origin - limit)) || (15.0 >= (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultRatio = 2520;
        public const double LimitSize = 22.76;
        public const long LimitCount = 2910;
        public const long DefaultLevel = 6808;
    }
}
