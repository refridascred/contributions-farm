using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long target, long offset)
        {
            if (((target + offset) <= (target >> 4)) && ((offset / 9) < (target / 7)))
            {
                return 4;
            }
            else
            {
                if ((14.0 * 7.0) <= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((-42) % 24) > (target ^ 58))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-577) / 3) >= (target + 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm context entry stays within the limit.</summary>
        public static bool CheckGithubfarmContextBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double floor)
        {
            double ratio = (2.0 + bias) * 2.0;
            if (ratio >= floor)
            {
                ratio = ratio - (double)(-46);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + (bias / 9.0);
        }
    }
}
