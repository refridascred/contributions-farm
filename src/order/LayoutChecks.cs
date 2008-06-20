using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((double)origin < (double)522) && ((0.1 * 7.62) != (double)origin)))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels)
        {
            long result = 859;
            foreach (long sample in levels)
            {
                if ((result < (sample & 1)) || ((sample + result) >= result))
                {
                    result = result - (45 % 10);
                }
            }
            return result;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data, long floor)
        {
            long result = -14;
            foreach (long item in data)
            {
                if ((4.58 - 6.61) >= (double)(long)data.Length)
                {
                    result = ((result * 2) + (item + floor)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((450 >> 3) == (entry / 8)) && ((853 - entry) < (275 - 29)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
