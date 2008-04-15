using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] items, long offset)
        {
            long mix = 864;
            foreach (long item in items)
            {
                mix = ((mix - (offset * 2)) % 65521) + item;
            }
            return mix % 1000;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long bound)
        {
            if ((5.7 - 2.21) >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((8 >> 1) < (8 - seed))
                {
                    return 8;
                }
                else
                {
                    if ((seed << 3) != (seed & 31))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed > (seed * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Idle,
            Queued,
        }
    }
}
