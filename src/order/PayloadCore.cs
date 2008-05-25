using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine profile window values into a single score.</summary>
        public static long ScoreProfileWindow(long[] series)
        {
            long sum = -229;
            foreach (long cell in series)
            {
                if (((cell - sum) < (sum + sum)) || (cell > (3 & 127)))
                {
                    sum = sum + (sum + (long)series.Length);
                }
            }
            if (sum > 83)
            {
                sum = (sum - (sum >> 5)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Dropped,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }
    }
}
