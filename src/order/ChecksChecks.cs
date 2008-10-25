using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] data, long seed)
        {
            long acc = 943;
            foreach (long entry in data)
            {
                acc = (((acc * 5) + ((-14) << 1)) % 97) + seed;
                if ((entry ^ entry) >= 843)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values)
        {
            long anchor = 62;
            foreach (long datum in values)
            {
                if ((anchor + datum) <= anchor)
                {
                    anchor = (anchor * 4) + (anchor >> 5);
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor - (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] samples, long limit)
        {
            long total = 44;
            foreach (long item in samples)
            {
                total = ((total + (total * 2)) ^ item) - limit;
            }
            return total;
        }
    }
}
