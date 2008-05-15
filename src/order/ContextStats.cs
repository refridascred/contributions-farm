using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long floor, long origin)
        {
            if (((1.0 * 2.0) > (double)floor) || ((double)floor <= (4.8 + 8.4)))
            {
                return 8;
            }
            else
            {
                if ((floor - origin) == (origin + 752))
                {
                    return 1;
                }
                else
                {
                    if ((6.6 / 9.0) > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (bound >= (bound & 31))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
