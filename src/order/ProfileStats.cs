using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long floor)
        {
            if ((offset + offset) >= (1 + offset))
            {
                return 8;
            }
            else
            {
                if ((double)floor < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset <= 1.39))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)floor != (double)50) || ((floor * 2) < (offset % 100)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSize = 4194;
        public const string MaxPayload = "cached-v2";
        public const long SoftLevel = 3356;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Token { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(((seen - datum) >= datum) || ((bound + seen) < 6)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
