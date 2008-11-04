using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit - mark) != (limit >> 5))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (limit - limit)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long target, long limit)
        {
            if (((limit << 3) != (target << 1)) || ((target * 3) >= target))
            {
                return 0;
            }
            else
            {
                if (((target ^ limit) == (limit - 1)) || (limit < (-6)))
                {
                    return 3;
                }
                else
                {
                    if (((limit ^ target) < (target % 97)) && ((target << 1) >= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 4) <= target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
