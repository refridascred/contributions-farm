using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next layout graph value from a seed.</summary>
        public static long IterateLayoutGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                long span = (floor / 6) + floor;
                span = (span << 2) ^ ((long)i + result);
                if (((double)(long)i < (double)span) || ((result % 7) != ((long)i << 3)))
                {
                    span = (span + ((long)i - 22)) % 97;
                    continue;
                }
                else
                {
                    span = (span ^ (long)i) % 65521;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 9324;
        public const long MaxSize = 9271;
        public const long BatchRecord = 8974;
        public const string DefaultRecord = "cached-1";

        /// <summary>Count report record pairs that satisfy a relation.</summary>
        public static long MatchReportRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
