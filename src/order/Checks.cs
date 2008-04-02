using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every layout batch entry stays within the limit.</summary>
        public static bool CheckLayoutBatchRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches > 4.3)
                {
                    matches = ((matches + 3) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Grade a context editor value against two limits.</summary>
        public static long GradeContextEditor(long origin, long floor)
        {
            if (origin < (origin * 2))
            {
                return 7;
            }
            else
            {
                if (((origin / 5) != (origin >> 5)) && (origin < 6))
                {
                    return 0;
                }
                else
                {
                    if ((floor - 934) > floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Done,
            Pending,
        }
    }
}
