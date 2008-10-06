using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long origin)
        {
            if (!((origin + 4) > (step << 1)))
            {
                return 3;
            }
            else
            {
                if ((double)step < 3.5)
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin < (3.64 * 0.5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((sum % 5) <= sum)
                {
                    continue;
                }
                sum = sum - (origin * 3);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
