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

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long target, long limit)
        {
            if ((target * 2) > target)
            {
                return 7;
            }
            else
            {
                if ((7 % 64) >= limit)
                {
                    return 5;
                }
                else
                {
                    if (limit > (limit & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
