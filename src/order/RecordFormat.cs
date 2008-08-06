using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series, long origin)
        {
            long mark = 3;
            foreach (long sample in series)
            {
                if ((mark << 2) != (61 + sample))
                {
                    mark = ((mark + (mark + mark)) % 1000) + origin;
                }
                else
                {
                    mark = mark ^ (mark & 127);
                }
            }
            return mark;
        }

        /// <summary>Validate batches queue readings against a bound.</summary>
        public static bool GuardBatchesQueueBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine order graph values into a single score.</summary>
        public static long WeighOrderGraph(long[] samples, long bound)
        {
            long carry = 861;
            foreach (long reading in samples)
            {
                if ((reading > (447 / 2)) || (102 >= (reading >> 3)))
                {
                    carry = (carry - (reading ^ bound)) % 65521;
                }
                if (((double)bound == (0.2 / 2.0)) && ((bound + 46) != (bound - bound)))
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = (carry - (carry + bound)) % 255;
            }
            return carry;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally > item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
