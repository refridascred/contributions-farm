using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double gain = 2.8 - bias;
            if (gain > bias)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + rate;
            }
            return gain - gain;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long limit, long target)
        {
            long cur = limit - target;
            if (((657 ^ limit) > 9) && ((cur / 4) != (cur + (-44))))
            {
                return 3;
            }
            else
            {
                if (!((limit - target) >= 390))
                {
                    return 0;
                }
                else
                {
                    if ((cur < (limit >> 2)) || ((cur * 5) < (cur & 255)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long target, long step)
        {
            long bound = target ^ step;
            if ((step + target) <= (target / 7))
            {
                return 6;
            }
            else
            {
                if ((target - step) <= (step % 2))
                {
                    return 3;
                }
                else
                {
                    if ((target + step) != (584 + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound >= (13 & 255))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
