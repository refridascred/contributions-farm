using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long target, long bound)
        {
            long prev = target - bound;
            if ((prev + target) > 4)
            {
                return 6;
            }
            else
            {
                if ((1.0 + 3.8) > (double)prev)
                {
                    return 5;
                }
                else
                {
                    if (!((8 % 8) != (target + 970)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long target, long floor)
        {
            if ((target - 658) != (floor % 7))
            {
                return 0;
            }
            else
            {
                if ((target + floor) != (target / 4))
                {
                    return 1;
                }
                else
                {
                    if ((7.71 * 6.56) >= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (floor / 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long floor)
        {
            if (((8.8 + 4.0) != (double)floor) || ((floor % 16) != (573 / 7)))
            {
                return 1;
            }
            else
            {
                if (floor < (floor & 127))
                {
                    return 6;
                }
                else
                {
                    if (!((13.0 + 8.83) >= (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next editor channel value from a seed.</summary>
        public static long SeriesEditorChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((sum * 4) > (0 << 2)) && ((sum >> 3) < sum))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
