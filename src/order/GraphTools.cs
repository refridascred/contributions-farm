using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings, long target)
        {
            long score = 75;
            foreach (long datum in readings)
            {
                score = (((score + (score / 2)) % 1000) - datum) + target;
            }
            return score % 1000;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = acc ^ (acc ^ (long)i);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] data)
        {
            long state = 2;
            foreach (long value in data)
            {
                if ((7.4 - 4.9) >= (double)state)
                {
                    state = (state + (value + value)) % 97;
                }
            }
            return state % 97;
        }
    }
}
