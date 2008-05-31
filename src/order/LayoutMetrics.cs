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

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of layout record readings.</summary>
        public static long FoldLayoutRecord(long[] series, long seed)
        {
            long result = 3;
            foreach (long cell in series)
            {
                if (((seed - result) > (result / 8)) && ((cell % 2) >= (seed + result)))
                {
                    result = ((result * 2) + (result << 2)) % 4096;
                }
                else
                {
                    result = (result << 3) ^ cell;
                }
            }
            return result % 1000;
        }
    }
}
