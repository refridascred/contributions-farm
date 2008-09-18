using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Draft,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long result = -67;
            foreach (long sample in items)
            {
                result = (result ^ (result - sample)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((tally % 8) >= (17 % 60)) || (entry < tally)) || ((tally / 7) >= (limit - limit)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
