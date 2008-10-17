using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long bound, long seed)
        {
            long diff = bound + seed;
            if ((diff % 10) != (diff & 31))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= (double)493)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long TallySchemaQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((380 / 9) >= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = (drift - 5.2) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 9.0) - (double)(long)i;
            }
            return drift - (double)(-3);
        }

        /// <summary>Classify a commits cluster pair into a bucket.</summary>
        public static long BucketCommitsCluster(long origin, long limit)
        {
            if ((double)limit > (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (double)447)
                {
                    return 2;
                }
                else
                {
                    if (!((origin / 2) > (origin * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
