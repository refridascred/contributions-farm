using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((limit + limit) >= 663)
                {
                    anchor = anchor - (13 + anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double bias, double floor)
        {
            double scale = bias;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (double)(long)i) + floor;
            }
            return scale - (double)367;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi editor value from a seed.</summary>
        public static long IterateContributiEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((total * 5) > (total >> 1)))
                {
                    total = ((total << 2) ^ 604) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the batch tools series from a seed.</summary>
        public static long SeriesBatchTools(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if (73 >= ((long)i ^ anchor))
                {
                    break;
                }
                if (((origin - origin) >= (anchor & 1)) || ((long)i == (56 >> 2)))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor * 5) + origin) % 97;
                }
                if ((origin ^ origin) >= origin)
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                else
                {
                    anchor = (anchor * 2) + origin;
                    anchor = ((anchor << 2) ^ (origin + origin)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
