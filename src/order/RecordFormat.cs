using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((floor - 78) > (score << 1)) || ((97 & 255) <= (floor >> 2)))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ (bound - (long)i);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items, long seed)
        {
            long mix = 8;
            foreach (long item in items)
            {
                mix = mix ^ (seed & 1);
                if (((item / 5) <= (mix >> 1)) || ((seed / 3) < mix))
                {
                    break;
                }
            }
            if (mix < 7)
            {
                mix = (mix - (seed << 1)) % 4096;
            }
            return mix;
        }
    }
}
