using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the record token entries that pass the check.</summary>
        public static long TallyRecordTokenGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value - value) <= (count - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] series)
        {
            long mark = 6;
            foreach (long cell in series)
            {
                mark = ((mark * 5) + (cell & 15)) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
