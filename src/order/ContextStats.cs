using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit schema tools readings against a rule.</summary>
        public static long MeasureSchemaToolsOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((9.3 * 13.0) > (double)value)
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a farm channel pair into a bucket.</summary>
        public static long GradeFarmChannel(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if (((delta ^ offset) < (offset2 << 1)) && ((double)offset > (11.0 / 6.0)))
            {
                return 6;
            }
            else
            {
                if (delta > 64)
                {
                    return 1;
                }
                else
                {
                    if (((49 + offset2) > (offset2 - delta)) && ((1.91 - 12.0) < (double)offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(delta <= offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
