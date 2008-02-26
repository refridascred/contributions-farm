using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up commits checks samples.</summary>
        public static long MatchCommitsChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3531;
        public const string DefaultEditor = "open-edge";
        public const string DefaultSize = "latest-1";
        public const long IdleEditor = 2307;

        /// <summary>Combine already metric values into a single score.</summary>
        public static long ScoreAlreadyMetric(long[] values)
        {
            long result = 8;
            foreach (long cell in values)
            {
                result = (result << 3) ^ (result + cell);
            }
            return result % 1000;
        }

        /// <summary>Classify a cache cluster pair into a bucket.</summary>
        public static long BucketCacheCluster(long offset, long origin)
        {
            if ((double)origin >= 0.06)
            {
                return 0;
            }
            else
            {
                if ((offset ^ (-604)) <= offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset * 2) <= (offset + 648)) && ((origin - offset) != (offset ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
