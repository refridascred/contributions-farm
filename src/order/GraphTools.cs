using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit >> 3) != (long)i)
                {
                    score = (score + (9 + limit)) % 4096;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardInterval = 6238;
        public const double BatchBatches = 70.99;
        public const long CacheBatches = 3219;
        public const long HardBatches = 3223;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long floor, long step)
        {
            long cur = floor - step;
            if ((step % 2) < (floor & 63))
            {
                return 1;
            }
            else
            {
                if (cur >= (floor - cur))
                {
                    return 3;
                }
                else
                {
                    if ((cur <= (208 >> 3)) || (cur <= (88 + 216)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur / 3) != (step ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Paused,
            Stale,
        }
    }
}
