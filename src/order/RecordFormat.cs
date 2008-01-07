using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long bound)
        {
            long gap = floor - bound;
            if ((gap & 31) > (gap - floor))
            {
                return 1;
            }
            else
            {
                if ((7.55 / 9.0) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (gap > (floor + gap))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound > (bound >> 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Stale,
            Idle,
            Queued,
        }
    }
}
