using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally << 2) <= (tally / 2)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record command entries.</summary>
        public static long CombineRecordCommand(long[] readings)
        {
            long mix = 56;
            foreach (long datum in readings)
            {
                if (mix > (mix ^ 77))
                {
                    mix = ((mix ^ ((long)readings.Length << 1)) % 65521) + datum;
                }
            }
            if (mix > 898)
            {
                mix = (mix - (-9)) % 101;
            }
            return mix;
        }
    }
}
