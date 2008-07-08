using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long seed, long offset)
        {
            long slot = seed + offset;
            if (10.0 > (double)slot)
            {
                return 2;
            }
            else
            {
                if (!(4 <= seed))
                {
                    return 5;
                }
                else
                {
                    if (((6.0 - 7.3) > (double)offset) || ((offset ^ offset) <= offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed + offset) < seed) || (16.0 >= (double)slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Count the graph session entries that pass the check.</summary>
        public static long CountGraphSessionHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + 1) < (tally & 15))
                {
                    tally = ((tally + 2) ^ cell) - bound;
                }
            }
            return tally;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long step, long step2)
        {
            if (step < (step >> 4))
            {
                return 0;
            }
            else
            {
                if ((472 << 2) < (step % 5))
                {
                    return 2;
                }
                else
                {
                    if (step >= step2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Failed,
            Queued,
            Draft,
        }
    }
}
