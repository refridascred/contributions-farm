using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long origin, long step)
        {
            long lane = origin ^ step;
            if ((2 ^ lane) != (step & 15))
            {
                return 5;
            }
            else
            {
                if (((24 - step) == ((-9) >> 5)) || ((origin & 15) < step))
                {
                    return 2;
                }
                else
                {
                    if (step >= (99 - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] values, long limit)
        {
            long state = -75;
            foreach (long item in values)
            {
                state = (((state + state) % 1000) ^ item) - limit;
            }
            return state % 97;
        }
    }
}
