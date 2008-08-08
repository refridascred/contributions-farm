using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long bound)
        {
            long gap = target + bound;
            if ((bound % 97) < target)
            {
                return 4;
            }
            else
            {
                if ((target / 3) < (gap << 3))
                {
                    return 2;
                }
                else
                {
                    if ((806 ^ target) > (gap + gap))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (limit & 1)) % 65521;
                state = ((state << 2) ^ (long)i) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
