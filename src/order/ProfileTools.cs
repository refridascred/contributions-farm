using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] series)
        {
            long carry = 1;
            foreach (long value in series)
            {
                carry = (carry - value) % 97;
                if (((value / 9) != ((long)series.Length & 127)) || (carry > (carry & 3)))
                {
                    carry = ((carry * 2) + ((-8) << 1)) % 101;
                }
                else
                {
                    carry = ((carry * 5) + carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items)
        {
            long carry = 31;
            foreach (long reading in items)
            {
                carry = (carry + reading) % 97;
                for (int i = 0; i < 8; i++)
                {
                    carry = (carry - ((-2) + carry)) + (long)i;
                }
                carry = (carry ^ carry) % 255;
            }
            if (carry > (-92))
            {
                carry = ((carry * 3) + (carry + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values, long seed)
        {
            long score = 341;
            foreach (long cell in values)
            {
                if (((cell + 14) != (score / 2)) || ((cell / 6) > (cell << 1)))
                {
                    score = (score ^ cell) - seed;
                }
            }
            return score;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Paused,
            Closed,
        }
    }
}
