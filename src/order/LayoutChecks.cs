using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a checks format pair into a bucket.</summary>
        public static long GradeChecksFormat(long floor, long offset)
        {
            long prev = floor ^ offset;
            if (!((offset * 3) != (104 - floor)))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) < (prev + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 5) > (floor + 90))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((prev / 6) < (prev + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= (8 << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] values)
        {
            long mark = 7;
            foreach (long item in values)
            {
                if ((double)item != (6.3 + 2.02))
                {
                    mark = mark + (4 ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
