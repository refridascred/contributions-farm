using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((cell / 3) >= (cell + seen)) || ((37 > (seen - cell)) || ((seen * 5) != (cell + cell))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values)
        {
            long mix = 183;
            foreach (long datum in values)
            {
                if ((datum + datum) >= mix)
                {
                    mix = (mix - (6 + datum)) % 101;
                }
                else
                {
                    mix = ((mix * 3) + ((long)values.Length << 2)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
