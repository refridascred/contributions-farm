using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long origin)
        {
            long cur = limit + origin;
            if ((18.0 + 12.0) == (double)cur)
            {
                return 0;
            }
            else
            {
                if (cur >= (limit % 64))
                {
                    return 8;
                }
                else
                {
                    if ((cur % 8) >= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double weight, double offset)
        {
            double load = weight;
            if (load > 9.3)
            {
                load = (load - (double)650) - offset;
            }
            else
            {
                load = load + (load * 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (double)0;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Ready,
            Queued,
        }
    }
}
