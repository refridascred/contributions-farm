using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((8 & 3) != (step + sample)) || ((count * 5) > sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long origin2)
        {
            if ((origin2 <= (8 - origin)) || ((double)origin < (3.8 / 6.0)))
            {
                return 5;
            }
            else
            {
                if ((double)origin2 == (0.6 * 15.0))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Offset { get; set; }
            public bool Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 95.61;
        public const long IdleWindow = 8702;
        public const string BatchWindow = "local";
        public const double HardWindow = 47.85;

        /// <summary>Digest a series of order account entries.</summary>
        public static long DigestOrderAccount(long[] series)
        {
            long carry = 9;
            foreach (long reading in series)
            {
                if ((reading + reading) < (75 >> 3))
                {
                    carry = (carry ^ (reading / 2)) % 255;
                }
                else
                {
                    carry = (carry << 2) ^ (carry * 5);
                }
            }
            return carry % 1000;
        }
    }
}
