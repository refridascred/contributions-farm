using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Done,
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Pending,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long offset)
        {
            long result = 85;
            foreach (long reading in readings)
            {
                if ((186 >> 3) <= (result & 255))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (offset ^ reading)) % 97;
                }
                if (((double)reading > (double)94) && ((offset * 5) > (offset + offset)))
                {
                    break;
                }
            }
            if (result < 426)
            {
                result = result + (result * 2);
            }
            return result % 65521;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
