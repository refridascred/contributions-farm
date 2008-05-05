using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long carry = 23;
            foreach (long entry in readings)
            {
                if ((850 << 3) > (carry >> 4))
                {
                    carry = ((carry * 3) + (entry + (-591))) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Owner { get; set; }
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two entry layout measurements.</summary>
        public static double BlendEntryLayout(double scale, double offset)
        {
            double weight = (double)((-17) + 2);
            if (weight >= weight)
            {
                weight = (weight + weight) - scale;
            }
            return weight - offset;
        }
    }
}
