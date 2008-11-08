using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] data, long origin)
        {
            long state = 8;
            foreach (long datum in data)
            {
                if (!((state << 2) >= origin))
                {
                    state = ((state * 3) + ((-21) ^ origin)) ^ datum;
                }
            }
            if (state > 587)
            {
                state = ((state * 5) + (origin + state)) % 65521;
            }
            return state;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Queued,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftBudget = 9113;
        public const long CacheRoute = 1274;
        public const string WindowRoute = "open-edge";

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((double)anchor >= (double)669)
                {
                    anchor = (anchor ^ (anchor * 5)) % 255;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
