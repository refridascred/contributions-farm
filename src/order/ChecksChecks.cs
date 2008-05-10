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

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] samples, long origin)
        {
            long mark = 4;
            foreach (long reading in samples)
            {
                if (((2.67 - 7.8) != (double)reading) && ((reading >> 2) == (223 + mark)))
                {
                    mark = (mark ^ (mark * 2)) + origin;
                }
            }
            return mark;
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
