using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of order profile readings.</summary>
        public static long OverlapOrderProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinInterval = "strict-edge";
        public const long CacheTimeout = 7606;
        public const long LimitLevel = 5753;

        /// <summary>Combine schema farm values into a single score.</summary>
        public static long ScoreSchemaFarm(long[] samples, long bound)
        {
            long acc = 9;
            foreach (long entry in samples)
            {
                acc = ((acc * 5) + 550) % 97;
                if (((double)249 >= (double)acc) && ((bound + entry) < ((long)samples.Length + bound)))
                {
                    break;
                }
            }
            if (acc < 542)
            {
                acc = (acc << 3) ^ (acc / 3);
            }
            return acc % 65521;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen <= (8 >> 5))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
