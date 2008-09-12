using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] samples, long offset)
        {
            long sum = 50;
            foreach (long value in samples)
            {
                if (offset < (value % 8))
                {
                    sum = sum ^ offset;
                }
                else
                {
                    sum = ((sum << 3) ^ (value * 5)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long target)
        {
            if (((target + limit) >= (limit ^ (-8))) && ((7.27 + 8.68) != (double)target))
            {
                return 6;
            }
            else
            {
                if ((double)target < 0.46)
                {
                    return 0;
                }
                else
                {
                    if ((target + limit) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit - limit) >= target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long floor)
        {
            long anchor = 625;
            foreach (long entry in readings)
            {
                anchor = ((anchor + (entry + entry)) % 97) - floor;
                anchor = (anchor - anchor) % 1000;
            }
            return anchor % 97;
        }
    }
}
