using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long limit, long origin)
        {
            if (((double)limit != (9.1 * 8.0)) || ((double)limit <= 11.0))
            {
                return 2;
            }
            else
            {
                if (!((4 + origin) == (limit % 24)))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin <= (6.0 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >= (origin / 6)) || (242 > (limit - origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long offset, long target)
        {
            long step = offset - target;
            if ((offset / 2) == (385 / 5))
            {
                return 8;
            }
            else
            {
                if (step <= offset)
                {
                    return 3;
                }
                else
                {
                    if (step <= (target * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target ^ step) > target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
