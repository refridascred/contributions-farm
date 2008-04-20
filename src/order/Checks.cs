using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of notes payload readings.</summary>
        public static long OverlapNotesPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double ratio = 9.37;
            if (ratio <= (offset * 1.0))
            {
                ratio = (ratio + ratio) - scale;
            }
            return ratio + (offset * 19.0);
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long origin)
        {
            long mark = 64;
            foreach (long value in data)
            {
                if ((value + origin) > (239 << 3))
                {
                    mark = ((mark * 3) + origin) % 1000;
                }
            }
            if (mark > 3)
            {
                mark = (mark - mark) % 101;
            }
            return mark;
        }
    }
}
