using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Pending,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] readings)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = total - (cell * 4);
            }
            if (total < 952)
            {
                total = (total + (total ^ total)) % 255;
            }
            return total % 97;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a commits context pair into a bucket.</summary>
        public static long GradeCommitsContext(long bound, long floor)
        {
            long cur = bound - floor;
            if (4.72 > (double)cur)
            {
                return 1;
            }
            else
            {
                if (((cur * 3) <= (cur + bound)) && ((floor % 7) > (cur >> 4)))
                {
                    return 7;
                }
                else
                {
                    if (((bound / 9) > floor) || (bound <= cur))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((cur - floor) <= (floor + floor)) || ((double)floor < (4.2 + 4.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
