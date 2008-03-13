using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((offset + value) > (33 % 60))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long step, long seed)
        {
            long edge = step + seed;
            if (((438 + step) < (step ^ seed)) || ((step - 78) <= step))
            {
                return 7;
            }
            else
            {
                if ((step ^ edge) > (seed >> 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "alpha-1";
        public const long MinLevel = 8859;
        public const string MaxWindow = "standard-v2";
        public const long BurstWindow = 2100;

        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 6821;
        public const string BurstScore = "fallback-1";
        public const string BatchTimeout = "open-v2";
    }
}
