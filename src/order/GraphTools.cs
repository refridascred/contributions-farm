using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series)
        {
            long score = 708;
            foreach (long cell in series)
            {
                if ((score / 5) >= (52 - cell))
                {
                    score = (score + (35 % 97)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Closed,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
