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

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long seed)
        {
            if (((0.33 * 8.36) > (double)step) && (6.0 > (double)seed))
            {
                return 6;
            }
            else
            {
                if ((double)step < (double)7)
                {
                    return 1;
                }
                else
                {
                    if (((step - step) < step) || ((step & 1) >= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed < (7.8 * 5.8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
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
