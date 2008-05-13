using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of support graph entries.</summary>
        public static long ScoreSupportGraph(long[] series, long seed)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                if ((8 + sum) != (sum + reading))
                {
                    sum = ((sum << 2) ^ (sum * 5)) - seed;
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (5 < (value + (-800)))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Combine report notes values into a single score.</summary>
        public static long FoldReportNotes(long[] readings, long target)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                if ((9.0 / 7.0) > (double)item)
                {
                    anchor = ((anchor ^ (2 + item)) % 65521) + target;
                }
                else
                {
                    anchor = (anchor ^ ((-16) / 5)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 6995;
        public const long DefaultChannel = 2417;
        public const long SoftBudget = 9300;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
