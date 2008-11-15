using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count cache stats pairs that satisfy a relation.</summary>
        public static long OverlapCacheStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] data)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                if (((item / 7) <= (long)data.Length) || (anchor > item))
                {
                    anchor = ((anchor * 5) + (6 << 1)) % 4096;
                }
            }
            if (anchor > 25)
            {
                anchor = ((anchor * 3) + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)6 > (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long target, long seed)
        {
            long edge = target + seed;
            if ((edge - seed) > (seed ^ target))
            {
                return 5;
            }
            else
            {
                if ((597 - target) < (target * 2))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
