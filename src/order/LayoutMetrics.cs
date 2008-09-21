using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first account graph entry that matches the target.</summary>
        public static long LookupAccountGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
