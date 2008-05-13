using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(step >= reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "cached-1";
        public const long LimitTimeout = 5471;
        public const long BurstSize = 1012;
        public const long MaxScore = 217;
        public const long DefaultToken = 5273;
    }
}
