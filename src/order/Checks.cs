using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long floor, long bound)
        {
            if ((double)floor == (0.1 - 8.7))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long limit, long step)
        {
            long span = limit + step;
            if ((68 + step) != (span << 3))
            {
                return 7;
            }
            else
            {
                if ((step & 255) <= 207)
                {
                    return 8;
                }
                else
                {
                    if (0.82 >= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
