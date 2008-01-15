using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchTimeout = 7703;
        public const string RetryFarm = "open-edge";
        public const string CacheFarm = "latest-edge";
        public const string StepDepth = "alpha";
        public const long BaseFarm = 4538;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items, long limit)
        {
            long acc = 2;
            foreach (long reading in items)
            {
                if ((8.94 / 4.0) >= (double)reading)
                {
                    acc = acc + (acc + limit);
                }
            }
            return acc;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long step, long bound)
        {
            long gap = step + bound;
            if (((double)gap < (double)15) || ((bound ^ step) < step))
            {
                return 4;
            }
            else
            {
                if (!((gap >> 1) == (step - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound - gap) >= 710)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((gap - bound) == (gap % 12))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first layout token entry that matches the target.</summary>
        public static long FindLayoutTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - (long)i) >= floor)
                {
                    anchor = anchor + ((long)i ^ anchor);
                }
                anchor = anchor - (floor ^ floor);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate window support readings against a bound.</summary>
        public static bool VerifyWindowSupportRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
