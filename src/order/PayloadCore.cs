using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((limit * 4) > (value + seen)) && (((5.3 + 3.0) == (double)seen) || ((seen << 2) != ((long)levels.Length / 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((double)carry != (8.0 * 9.4))
                {
                    carry = (carry << 3) ^ (long)i;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
