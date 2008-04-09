using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Flag { get; set; }
            public bool Offset { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a payload batches pair into a bucket.</summary>
        public static long BucketPayloadBatches(long step, long limit)
        {
            long step2 = step - limit;
            if (!((limit << 2) >= (step - 47)))
            {
                return 2;
            }
            else
            {
                if (((step / 4) < (limit * 2)) || (limit < step2))
                {
                    return 8;
                }
                else
                {
                    if ((868 >> 5) < limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step2 + 4) >= 14) && ((step2 - step) <= (step2 & 255)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
