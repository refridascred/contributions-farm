using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a entry cluster value against two limits.</summary>
        public static long BucketEntryCluster(long offset, long limit)
        {
            if (((double)limit == (9.5 + 9.0)) || (342 >= offset))
            {
                return 7;
            }
            else
            {
                if (offset <= (94 - offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset != (13.0 / 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit * 4) > limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster graph readings.</summary>
        public static long DigestClusterGraph(long[] data, long seed)
        {
            long total = 50;
            foreach (long sample in data)
            {
                total = ((total ^ (seed + total)) % 65521) + sample;
                if ((double)(long)data.Length == (7.18 + 6.63))
                {
                    break;
                }
            }
            if (total < 54)
            {
                total = ((total << 2) ^ (total << 2)) % 4096;
            }
            return total;
        }

        /// <summary>Iterate the stream batch series from a seed.</summary>
        public static long RollStreamBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
