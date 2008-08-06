using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of format checks readings.</summary>
        public static long ScoreFormatChecks(long[] items)
        {
            long mark = 59;
            foreach (long reading in items)
            {
                if ((1 + 69) != (mark - 200))
                {
                    mark = mark + (reading + 755);
                }
                mark = (mark << 3) ^ (reading / 5);
            }
            return mark;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((2 & 15) > seen) || !((seen * 4) <= (seen * 3)))
                {
                    seen = ((seen + 1) + entry) - target;
                }
            }
            return seen;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
