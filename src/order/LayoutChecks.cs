using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values, long limit)
        {
            long carry = 738;
            foreach (long reading in values)
            {
                carry = ((carry * 4) + carry) - reading;
            }
            if (carry > (-851))
            {
                carry = carry + (limit >> 2);
            }
            return carry % 65521;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)bound < (8.0 - 3.2))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 3249;
        public const double LimitNotes = 21.54;
        public const long DefaultRatio = 1011;

        /// <summary>Digest a series of graph report entries.</summary>
        public static long DigestGraphReport(long[] items)
        {
            long result = 9;
            foreach (long entry in items)
            {
                result = result - (entry % 100);
            }
            if (result < 378)
            {
                result = (result - result) % 101;
            }
            return result;
        }
    }
}
