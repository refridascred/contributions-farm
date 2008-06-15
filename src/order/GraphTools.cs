using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate contributi support samples.</summary>
        public static long TotalContributiSupport(long[] readings)
        {
            long carry = 1;
            foreach (long entry in readings)
            {
                if (!(carry <= 325))
                {
                    carry = (((carry * 5) + carry) % 4096) + entry;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many channel counter samples are out of range.</summary>
        public static long CountChannelCounterHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell / 3) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (value > (value % 97))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
