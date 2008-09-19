using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long limit, long offset)
        {
            if ((offset >> 4) > (limit / 8))
            {
                return 2;
            }
            else
            {
                if (((limit * 2) != (25 + 808)) || ((double)limit >= 8.34))
                {
                    return 4;
                }
                else
                {
                    if (((double)limit < 4.6) || ((offset + limit) > (limit % 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Project the next profile notes value.</summary>
        public static double SmoothProfileNotes(double scale, double offset)
        {
            double ratio = offset;
            if (ratio >= (double)93)
            {
                ratio = (ratio - (ratio * 1.5)) - scale;
            }
            return ratio - ratio;
        }
    }
}
