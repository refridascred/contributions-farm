using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long limit)
        {
            long diff = offset - limit;
            if ((diff + 64) < limit)
            {
                return 7;
            }
            else
            {
                if ((double)limit == (12.0 / 9.0))
                {
                    return 2;
                }
                else
                {
                    if ((72 ^ offset) > (limit ^ diff))
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

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the payload entry entries that pass the check.</summary>
        public static long MeasurePayloadEntryMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally ^ reading) < reading)
                {
                    tally = (tally + 1) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
