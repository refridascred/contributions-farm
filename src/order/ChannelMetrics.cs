using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = -73;
            foreach (long item in levels)
            {
                score = score ^ (item + item);
                if ((double)75 > (double)item)
                {
                    score = ((score << 3) ^ (item - item)) % 101;
                }
                else
                {
                    score = (score - (score + 1)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long sum = 8;
            foreach (long datum in readings)
            {
                sum = ((sum + sum) % 4096) - datum;
            }
            if (sum < 82)
            {
                sum = (sum + (sum - 393)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Count format schema pairs that satisfy a relation.</summary>
        public static long MatchFormatSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
