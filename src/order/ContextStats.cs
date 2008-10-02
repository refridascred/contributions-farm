using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up command window samples.</summary>
        public static long OverlapCommandWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (floor << 3)) % 255;
                if ((carry / 4) >= (floor - floor))
                {
                    carry = (carry + (carry % 3)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ 701) % 101;
                }
                if (!((floor + floor) <= floor))
                {
                    carry = (carry ^ (carry % 16)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Dropped,
            Failed,
            Draft,
            Paused,
        }
    }
}
