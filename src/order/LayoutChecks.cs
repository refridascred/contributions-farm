using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a checks format pair into a bucket.</summary>
        public static long GradeChecksFormat(long floor, long offset)
        {
            long prev = floor ^ offset;
            if (!((offset * 3) != (104 - floor)))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) < (prev + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 5) > (floor + 90))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((prev / 6) < (prev + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of window cache readings.</summary>
        public static long PairWindowCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits <= (4 & 7))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)tally >= (19.0 / 6.0)) || (limit <= tally))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] values)
        {
            long total = 843;
            foreach (long entry in values)
            {
                if (((double)total > (8.6 * 4.4)) || ((total / 7) == (86 >> 3)))
                {
                    break;
                }
                if ((total ^ (long)values.Length) == (entry + total))
                {
                    total = total - entry;
                }
                if ((14.0 * 4.7) < (double)total)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
