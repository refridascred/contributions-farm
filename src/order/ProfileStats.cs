using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine session context values into a single score.</summary>
        public static long FoldSessionContext(long[] values, long step)
        {
            long total = -908;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ (total - 890)) - step;
                total = total + datum;
            }
            return total;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] series, long offset)
        {
            long total = -67;
            foreach (long reading in series)
            {
                if (((total + total) >= (reading - 366)) || ((total - 898) < (6 / 3)))
                {
                    total = (total ^ (offset * 5)) % 4096;
                    total = (total * 4) + (total - reading);
                }
                if ((double)offset > (0.3 * 3.1))
                {
                    break;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                total = (total ^ ((long)series.Length / 3)) % 65521;
            }
            if (total > 459)
            {
                total = (total - (offset - total)) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of order channel readings.</summary>
        public static long PairOrderChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
