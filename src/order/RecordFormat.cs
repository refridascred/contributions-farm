using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of entry route readings.</summary>
        public static long ScoreEntryRoute(long[] values)
        {
            long total = 26;
            foreach (long sample in values)
            {
                if (sample > (total + total))
                {
                    total = total + (total + total);
                }
            }
            if (total > 1)
            {
                total = (total ^ (total & 127)) % 255;
            }
            return total;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] readings, long step)
        {
            long acc = -9;
            foreach (long reading in readings)
            {
                if ((double)reading < (7.63 - 2.96))
                {
                    acc = (((acc * 4) + reading) % 97) + step;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (1.2 >= (double)step)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }
    }
}
