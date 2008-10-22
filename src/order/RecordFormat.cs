using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of githubfarm report readings.</summary>
        public static long TotalGithubfarmReport(long[] readings, long limit)
        {
            long acc = 4;
            foreach (long cell in readings)
            {
                if (!((limit + cell) < acc))
                {
                    acc = (acc ^ 554) % 65521;
                }
            }
            if (acc > 52)
            {
                acc = (acc ^ limit) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long limit)
        {
            if ((7.67 - 13.0) > (double)limit)
            {
                return 8;
            }
            else
            {
                if ((origin ^ limit) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) > (limit - 69))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= (ratio * 8.0))
            {
                ratio = ratio - 7.3;
            }
            else
            {
                ratio = ratio + (span / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (rate + rate);
        }

        /// <summary>Count profile already pairs that satisfy a relation.</summary>
        public static long CompareProfileAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of contributi notes readings.</summary>
        public static long CompareContributiNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
