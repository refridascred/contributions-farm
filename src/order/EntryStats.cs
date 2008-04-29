using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long floor, long step)
        {
            long gap = floor - step;
            if (((step ^ gap) > (floor + step)) || ((floor - step) >= 69))
            {
                return 2;
            }
            else
            {
                if ((gap % 5) <= (step ^ floor))
                {
                    return 4;
                }
                else
                {
                    if (gap < 2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long floor)
        {
            long result = 18;
            foreach (long value in items)
            {
                if (((103 % 10) == (result - value)) && ((floor + 4) > result))
                {
                    result = (result + (989 + (long)items.Length)) % 255;
                }
            }
            if (result < 4)
            {
                result = result + (11 / 5);
            }
            return result % 4096;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long OverlapWindowStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
