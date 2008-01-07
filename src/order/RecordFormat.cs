using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value <= (tally * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long origin, long seed)
        {
            if (seed < (seed / 6))
            {
                return 1;
            }
            else
            {
                if (((seed + seed) <= (origin << 1)) || ((seed ^ 1) >= (seed ^ origin)))
                {
                    return 0;
                }
                else
                {
                    if (((seed >> 5) <= (seed % 64)) || (13.0 >= (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed + origin) != (origin & 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if ((double)step > (9.2 - 6.0))
                {
                    mix = ((mix << 3) ^ ((long)i - mix)) % 255;
                    continue;
                }
                mix = (mix + (step + step)) % 97;
                mix = ((mix * 2) + (mix - mix)) % 1000;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double weight = (double)49 - (scale - floor);
            if (weight >= 2.91)
            {
                weight = weight + 16.0;
            }
            return weight + (double)65;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples)
        {
            long total = 7;
            foreach (long reading in samples)
            {
                total = total ^ (total - reading);
                total = (total - (reading ^ total)) % 4096;
                total = (total ^ (total - reading)) % 97;
            }
            return total;
        }
    }
}
