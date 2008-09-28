using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a schema buffer figure with a bias.</summary>
        public static double ScaleSchemaBuffer(double rate, double bias)
        {
            double ratio = bias * 2.8;
            if (ratio >= rate)
            {
                ratio = ratio + ratio;
            }
            return ratio - ratio;
        }

        /// <summary>Rank commits cluster input into a small class.</summary>
        public static long GradeCommitsCluster(long target, long floor)
        {
            long step = target - floor;
            if ((target + floor) > (546 + target))
            {
                return 1;
            }
            else
            {
                if ((41 >> 3) == (3 - target))
                {
                    return 3;
                }
                else
                {
                    if ((415 >> 3) < target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step ^ 80) >= 4)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes window entry stays within the limit.</summary>
        public static bool CheckNotesWindowLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
