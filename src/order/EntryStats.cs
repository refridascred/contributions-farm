using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Queued,
            Ready,
            New,
            Locked,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double ratio = (double)(8 >> 2);
            for (int i = 0; i < 8; i++)
            {
                ratio = (((ratio - ratio) - (double)(long)i) + scale) - span;
            }
            return ratio - (double)17;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Match up report layout samples.</summary>
        public static long CompareReportLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Draft,
            Locked,
            Failed,
        }
    }
}
