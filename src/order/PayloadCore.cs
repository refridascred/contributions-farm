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

        /// <summary>Match up context profile samples.</summary>
        public static long CompareContextProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
