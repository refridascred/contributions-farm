using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 4000;
        public const string BurstBatches = "primary-1";
        public const string HardBatches = "latest";
        public const string HardTimeout = "stable";

        /// <summary>Grade a schema record value against two limits.</summary>
        public static long GradeSchemaRecord(long target, long floor)
        {
            long diff = target - floor;
            if ((target + target) < (diff << 1))
            {
                return 6;
            }
            else
            {
                if ((floor / 8) < (diff + diff))
                {
                    return 1;
                }
                else
                {
                    if (floor <= (diff * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.3 * 3.2) != (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long limit)
        {
            if (offset <= (offset % 97))
            {
                return 4;
            }
            else
            {
                if ((double)limit > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset >= (2.02 / 4.0)) && ((limit - limit) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3.0 * 1.0) != (double)limit) && ((limit + offset) >= offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
