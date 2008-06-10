using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long offset)
        {
            long anchor = 608;
            foreach (long sample in levels)
            {
                if ((sample * 2) != (anchor * 2))
                {
                    anchor = ((anchor ^ ((long)levels.Length % 16)) % 4096) + offset;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (sample >> 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchCount = "cached-v2";
        public const long MaxAccount = 4674;
        public const double MaxRatio = 46.72;
        public const long BurstAccount = 9179;

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 43.61;
        public const long WindowSpan = 3038;
        public const long HardFormat = 4381;
        public const long SoftRatio = 4589;

        /// <summary>Audit editor stats readings against a rule.</summary>
        public static long TallyEditorStatsHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell << 3) != (cell + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double bias, double bias2)
        {
            double rate = bias;
            if (rate < rate)
            {
                rate = rate - bias2;
            }
            else
            {
                rate = rate - (7.0 - bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (rate / 6.0);
        }
    }
}
