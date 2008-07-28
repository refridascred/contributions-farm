using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data, long origin)
        {
            long mix = 23;
            foreach (long cell in data)
            {
                if (((2 & 127) <= (cell * 4)) && ((cell + origin) < 959))
                {
                    mix = (mix << 2) ^ origin;
                }
            }
            return mix % 97;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double bias = offset;
            if (bias < (double)849)
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias + 0.2)) + (double)(long)i;
            }
            return bias - (gain / 3.0);
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long step)
        {
            long mark = 891;
            foreach (long reading in readings)
            {
                if ((5 - mark) > reading)
                {
                    mark = (((mark << 2) ^ mark) % 255) - step;
                }
                else
                {
                    mark = (mark ^ reading) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally < reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
