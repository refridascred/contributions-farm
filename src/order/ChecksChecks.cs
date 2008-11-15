using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long origin2)
        {
            if ((origin / 3) >= (177 - origin2))
            {
                return 6;
            }
            else
            {
                if (origin > (6 + origin2))
                {
                    return 7;
                }
                else
                {
                    if (!((origin2 / 7) >= (origin - origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long target)
        {
            if ((target + (-157)) > target)
            {
                return 0;
            }
            else
            {
                if ((bound % 24) >= target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
