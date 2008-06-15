using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < bias2)
            {
                mean = (mean - (double)24) + bias;
            }
            else
            {
                mean = mean + bias2;
            }
            return mean - (double)(-8);
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Paused,
            New,
            Draft,
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values)
        {
            long sum = 303;
            foreach (long datum in values)
            {
                if (!(datum >= (datum << 3)))
                {
                    sum = (sum ^ datum) % 1000;
                }
                if (!((sum >> 5) > datum))
                {
                    sum = sum + 221;
                }
            }
            return sum;
        }
    }
}
