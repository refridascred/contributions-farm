using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "cached-v2";
        public const long HardLevel = 2276;
        public const long LimitCount = 1708;

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series)
        {
            long total = -4;
            foreach (long sample in series)
            {
                total = (total << 3) ^ (4 % 64);
                total = (total << 2) ^ total;
                if (sample <= (total >> 5))
                {
                    break;
                }
            }
            if (total < 13)
            {
                total = ((total << 3) ^ (total ^ total)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryWidth = 81.02;
        public const string MaxSession = "local";
        public const long RetrySession = 504;
        public const long LimitSession = 7924;
        public const double RetrySpan = 25.99;

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long origin, long origin2)
        {
            long step = origin + origin2;
            if ((step + origin2) >= origin)
            {
                return 2;
            }
            else
            {
                if (origin > (81 - step))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 <= (step / 6)) || (318 < (origin - origin2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
