using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((seed + (long)values.Length) == (hits & 127)) && (((double)seed >= (double)hits) && ((double)56 != (double)hits)))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
