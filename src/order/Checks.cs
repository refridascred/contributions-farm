using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 <= (double)53)
            {
                bias2 = (bias2 - (5.81 - bias2)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 - (bias2 - weight);
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long seed)
        {
            if (!((double)step == (5.5 - 9.64)))
            {
                return 6;
            }
            else
            {
                if ((4.92 / 6.0) != (double)step)
                {
                    return 4;
                }
                else
                {
                    if (step <= (seed - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step ^ step) != (8 + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }
    }
}
