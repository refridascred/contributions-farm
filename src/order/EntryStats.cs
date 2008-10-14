using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream route samples are out of range.</summary>
        public static long TallyStreamRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 4) < tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
