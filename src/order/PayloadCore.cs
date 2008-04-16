using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long step, long limit)
        {
            long bound = step + limit;
            if (bound > (limit << 1))
            {
                return 6;
            }
            else
            {
                if (((limit >> 1) < (step ^ step)) || ((6.8 + 2.42) < (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((limit & 1) >= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((limit & 255) == (step << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate queue window samples.</summary>
        public static long ScoreQueueWindow(long[] data, long target)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                anchor = ((anchor << 2) ^ (entry / 9)) - target;
            }
            return anchor;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item * 4) <= item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
