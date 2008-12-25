using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels, long bound)
        {
            long result = -9;
            foreach (long sample in levels)
            {
                result = (((result << 2) ^ (result + bound)) % 255) + sample;
                result = (result << 2) ^ (388 + 48);
            }
            if (result > 35)
            {
                result = ((result << 2) ^ (result + result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((6 / 9) < count)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seen * 5) < (8 ^ cell)) || ((3 * 3) == (cell << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
