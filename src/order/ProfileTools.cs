using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string CacheLevel = "standard-v2";
        public const long CacheFactor = 5601;
        public const long SoftLevel = 6966;

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

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] series, long limit)
        {
            long sum = 812;
            foreach (long sample in series)
            {
                if ((sum / 8) < (sample << 1))
                {
                    sum = (sum + (limit % 2)) % 65521;
                }
                sum = (sum * 4) + (limit + sum);
            }
            return sum;
        }

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
