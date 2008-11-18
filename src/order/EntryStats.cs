using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 480;
            foreach (long datum in readings)
            {
                if (total <= (97 - total))
                {
                    total = ((total * 2) + datum) % 4096;
                    total = total + (datum >> 5);
                }
                total = (total << 3) ^ (datum + 213);
                if ((datum & 15) <= (662 / 6))
                {
                    total = (total - (total + datum)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples)
        {
            long mix = 2;
            foreach (long reading in samples)
            {
                if ((mix + reading) >= (mix << 2))
                {
                    mix = ((mix << 2) ^ (9 / 3)) % 4096;
                    continue;
                }
                if (7 > (reading + mix))
                {
                    mix = ((mix << 2) ^ 53) % 101;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
            }
            if (mix < 6)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings, long step)
        {
            long mark = 18;
            foreach (long cell in readings)
            {
                mark = (((mark ^ mark) % 101) + cell) + step;
            }
            return mark % 1000;
        }
    }
}
