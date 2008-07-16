using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Closed,
            New,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Idle,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxInterval = 83.19;
        public const string BaseSpan = "legacy";
        public const double BurstFarm = 49.19;
        public const long SoftSize = 7636;

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long limit)
        {
            if (!((double)limit < (8.88 - 5.8)))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) <= (limit + origin))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 2) > (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.16 + 9.5) <= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!!((entry >> 2) == (entry - floor)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
