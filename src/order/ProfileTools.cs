using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (3.1 > (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster payload readings.</summary>
        public static long ScoreClusterPayload(long[] levels)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                if (((sample - sample) > (anchor + (-657))) && ((anchor % 3) <= (sample - sample)))
                {
                    anchor = (anchor + (7 >> 5)) % 65521;
                }
                else
                {
                    anchor = (anchor << 2) ^ (sample << 1);
                }
                if (!((17 << 3) < anchor))
                {
                    anchor = (anchor << 3) ^ (sample / 3);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Idle,
            New,
            Synced,
            Pending,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            Idle,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
