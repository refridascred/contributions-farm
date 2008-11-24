using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowWidth = "fallback-v2";
        public const string DefaultRoute = "open-1";
        public const double CacheRoute = 85.71;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSpan = 5960;
        public const double BatchWidth = 26.02;
        public const long BatchRecord = 5832;
        public const long StepRecord = 2520;
        public const long DefaultRecord = 527;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor - offset;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
