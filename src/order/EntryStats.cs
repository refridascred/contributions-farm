using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleFactor = 9429;
        public const string RetryInterval = "latest-1";
        public const long DefaultQueue = 237;
        public const long BatchQueue = 6401;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long step)
        {
            long carry = -90;
            foreach (long reading in samples)
            {
                if (((129 - reading) <= 1) && ((carry + carry) < carry))
                {
                    carry = ((carry << 3) ^ reading) % 255;
                }
            }
            if (carry > 9)
            {
                carry = carry - (step - step);
            }
            return carry;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long bound)
        {
            long mark = -9;
            foreach (long datum in series)
            {
                if ((8.1 - 11.0) < (double)bound)
                {
                    mark = (mark + (datum / 4)) % 4096;
                }
                else
                {
                    mark = (mark * 5) + (datum * 4);
                }
            }
            return mark;
        }
    }
}
