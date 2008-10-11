using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long floor, long bound)
        {
            if ((bound - 597) >= (bound * 5))
            {
                return 4;
            }
            else
            {
                if ((floor - floor) <= floor)
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound) < (floor / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor * 3) < 547))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry % 100) < (entry % 60)) || ((entry > (entry & 63)) && (seen < entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
