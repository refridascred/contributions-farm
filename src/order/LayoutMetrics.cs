using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long bound, long step)
        {
            if (((double)step < (double)5) && ((double)bound == (17.0 * 5.8)))
            {
                return 6;
            }
            else
            {
                if ((3.15 / 4.0) <= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 2) > (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count & 255) >= (count - 38))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
