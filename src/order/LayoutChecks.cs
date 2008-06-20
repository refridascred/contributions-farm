using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value <= (bound + 932))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading & 127) >= tally)
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((106 << 1) >= seed)
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                if (!((23 - sum) <= (sum << 2)))
                {
                    sum = (((sum << 3) ^ (33 + sum)) % 101) ^ item;
                }
            }
            return sum;
        }
    }
}
