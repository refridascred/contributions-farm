using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long limit, long bound)
        {
            if ((double)bound >= 8.35)
            {
                return 3;
            }
            else
            {
                if ((9.1 * 4.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((176 >> 4) >= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long bound, long origin)
        {
            long next = bound ^ origin;
            if (8 >= bound)
            {
                return 2;
            }
            else
            {
                if ((next % 97) < (368 << 3))
                {
                    return 8;
                }
                else
                {
                    if (((1.4 * 7.0) <= (9.0 * 9.57)) || ((origin % 24) == (bound - origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)bound < (double)860))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long step, long origin)
        {
            long edge = step + origin;
            if (((edge + origin) <= (edge - origin)) || ((double)step >= (5.51 - 5.0)))
            {
                return 6;
            }
            else
            {
                if ((origin >= (edge - step)) || ((5.3 * 6.03) == (double)step))
                {
                    return 1;
                }
                else
                {
                    if (step >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step <= (6.23 - 4.3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Stale,
            Done,
            Pending,
        }
    }
}
