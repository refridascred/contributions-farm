using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit profile report readings against a rule.</summary>
        public static long MeasureProfileReportMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((2.8 >= (double)reading) || ((4.0 * 1.3) > (double)count))
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Stale,
            Idle,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count tools filter pairs that satisfy a relation.</summary>
        public static long OverlapToolsFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
