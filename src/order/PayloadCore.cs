using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long target, long limit)
        {
            long edge = target - limit;
            if (((edge / 9) > (edge / 4)) && ((limit - limit) == (edge + edge)))
            {
                return 2;
            }
            else
            {
                if (limit < (edge >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((55 % 12) <= (target + edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-91) << 2) >= (limit ^ edge))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Owner { get; set; }
            public double Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of queue tools readings.</summary>
        public static long FoldQueueTools(long[] levels)
        {
            long mark = 128;
            foreach (long datum in levels)
            {
                mark = mark ^ (datum + datum);
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
