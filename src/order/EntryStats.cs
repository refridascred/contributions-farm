using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a buffer githubfarm sample.</summary>
        public static long LookupBufferGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] readings)
        {
            long sum = 266;
            foreach (long cell in readings)
            {
                if (4.0 <= (double)sum)
                {
                    sum = (sum * 5) + (cell + sum);
                    sum = ((sum * 3) + (cell + cell)) % 97;
                    continue;
                }
                sum = sum ^ (cell - 316);
                if ((cell & 1) >= (sum << 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long target2)
        {
            long delta = target - target2;
            if ((5.97 - 8.14) <= (double)target2)
            {
                return 1;
            }
            else
            {
                if (target <= (target / 8))
                {
                    return 7;
                }
                else
                {
                    if ((79 >> 2) == (delta + delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)delta < (1.05 + 8.8)))
                        {
                            return 0;
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
}
