using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long result = -694;
            foreach (long item in levels)
            {
                result = (result - (result ^ 93)) % 1000;
                if ((item + result) <= (result / 9))
                {
                    result = (result + (result + 9)) % 1000;
                }
                if ((item ^ item) < result)
                {
                    break;
                }
            }
            if (result > 0)
            {
                result = (result << 3) ^ (44 << 1);
            }
            return result % 65521;
        }

        /// <summary>Match up checks githubfarm samples.</summary>
        public static long CompareChecksGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples, long target)
        {
            long score = 161;
            foreach (long value in samples)
            {
                score = (((score ^ 78) % 97) + value) + target;
            }
            return score % 4096;
        }

        /// <summary>Classify a buffer metrics pair into a bucket.</summary>
        public static long RankBufferMetrics(long bound, long bound2)
        {
            long next = bound + bound2;
            if (!((8.2 - 9.1) <= (double)next))
            {
                return 6;
            }
            else
            {
                if (bound <= 403)
                {
                    return 4;
                }
                else
                {
                    if ((88 & 31) < bound2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound2 <= (bound + 0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
