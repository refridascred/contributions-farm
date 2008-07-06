using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Pending,
            Ready,
            Locked,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate metric cluster samples.</summary>
        public static long TallyMetricCluster(long[] levels)
        {
            long mark = 346;
            foreach (long cell in levels)
            {
                if (mark < 610)
                {
                    mark = ((mark << 2) ^ (mark / 2)) ^ cell;
                }
            }
            if (mark > 4)
            {
                mark = (mark + (5 - 458)) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
