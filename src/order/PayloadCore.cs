using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if (((double)step > (double)690) || ((sum / 6) == (sum % 100)))
                {
                    continue;
                }
                else
                {
                    sum = (sum + sum) % 255;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                if ((cell <= (anchor + anchor)) && ((double)(long)levels.Length >= (4.2 * 4.0)))
                {
                    anchor = (anchor - cell) % 4096;
                }
                else
                {
                    anchor = anchor - (anchor ^ cell);
                }
                if ((cell + cell) >= anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit record filter readings against a rule.</summary>
        public static long CountRecordFilterGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((hits + hits) != (hits << 1)))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
