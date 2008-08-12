using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels, long origin)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                anchor = (anchor ^ (cell * 4)) % 255;
                anchor = anchor - origin;
            }
            return anchor;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Idle,
            New,
            Draft,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Locked,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Pending,
            Failed,
        }
    }
}
