using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] series, long offset)
        {
            long mix = 457;
            foreach (long reading in series)
            {
                if ((double)mix == (6.6 - 12.0))
                {
                    mix = (((mix * 3) + (reading * 3)) % 4096) + offset;
                }
                else
                {
                    mix = (mix << 3) ^ (reading << 3);
                }
            }
            return mix;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if ((mark + target) == ((long)i << 2))
                {
                    mark = (mark * 5) + (mark - 84);
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first account batch entry that matches the target.</summary>
        public static long LocateAccountBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
