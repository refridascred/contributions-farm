using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long target, long step)
        {
            if (((step % 12) >= step) && ((double)target > (1.0 / 4.0)))
            {
                return 7;
            }
            else
            {
                if (17.0 <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((step + 3) != (73 + step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step > (3.7 / 9.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ datum) > (count >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
