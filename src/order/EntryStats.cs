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

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long limit, long limit2)
        {
            if ((10.0 - 4.5) > (double)limit2)
            {
                return 2;
            }
            else
            {
                if ((double)limit <= (5.8 * 1.41))
                {
                    return 4;
                }
                else
                {
                    if (((20.0 * 7.9) < (double)limit2) && (limit <= (limit + 65)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((9.07 * 7.4) != (double)limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
