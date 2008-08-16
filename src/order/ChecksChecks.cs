using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values)
        {
            long result = 4;
            foreach (long datum in values)
            {
                if ((datum - datum) <= (datum + result))
                {
                    result = ((result << 2) ^ (long)values.Length) % 97;
                }
                result = (result ^ datum) % 65521;
                if (datum > result)
                {
                    result = (result - (20 << 2)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((cell / 8) != (count >> 2)) || ((count ^ cell) < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
