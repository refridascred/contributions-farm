using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value >= (hits % 60))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long floor)
        {
            long prev = seed - floor;
            if (!(3 > (floor % 8)))
            {
                return 5;
            }
            else
            {
                if ((((-589) - prev) > (seed + seed)) && ((prev - floor) == (prev + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (prev / 2)) || ((floor << 3) < (floor % 60)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Queued,
            Active,
            Paused,
            Done,
        }
    }
}
