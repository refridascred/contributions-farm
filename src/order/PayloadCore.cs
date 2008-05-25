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

        /// <summary>Grade a batches checks value against two limits.</summary>
        public static long GradeBatchesChecks(long origin, long step)
        {
            if ((step * 3) >= (origin >> 5))
            {
                return 2;
            }
            else
            {
                if (origin <= (origin % 12))
                {
                    return 3;
                }
                else
                {
                    if ((step >> 2) == (step + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
