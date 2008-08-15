using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a record filter pair into a bucket.</summary>
        public static long SortRecordFilter(long origin, long seed)
        {
            long edge = origin + seed;
            if ((seed + edge) <= seed)
            {
                return 0;
            }
            else
            {
                if ((edge << 2) < (edge * 2))
                {
                    return 7;
                }
                else
                {
                    if ((origin - edge) < (seed + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = (score - limit) % 255;
                score = ((score * 2) + limit) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + bound) % 255;
                sum = sum ^ (bound << 3);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long bound, long step)
        {
            if (bound > (step - step))
            {
                return 6;
            }
            else
            {
                if ((double)step <= 1.5)
                {
                    return 8;
                }
                else
                {
                    if ((step + 69) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound >> 1) < 4) && ((double)step >= (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
