using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long offset)
        {
            if (456 <= bound)
            {
                return 7;
            }
            else
            {
                if (69 >= (offset & 127))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound < (3.6 + 1.13))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset ^ bound) > bound) || ((bound - offset) >= (bound << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen >= (15.0 + 2.15))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools metrics series from a seed.</summary>
        public static long DeriveToolsMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)score > (4.7 * 1.0)))
                {
                    score = (score + (4 + (long)i)) % 4096;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
