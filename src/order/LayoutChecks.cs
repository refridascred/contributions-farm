using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long offset)
        {
            long anchor = 608;
            foreach (long sample in levels)
            {
                if ((sample * 2) != (anchor * 2))
                {
                    anchor = ((anchor ^ ((long)levels.Length % 16)) % 4096) + offset;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (sample >> 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((double)offset >= 14.0) && ((double)(long)i > (16.0 / 9.0)))
                {
                    result = (result << 3) ^ ((long)i * 2);
                }
                result = result - ((long)i ^ (long)i);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score + 45);
                score = (score ^ (bound / 9)) % 101;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 8604;
        public const string BaseBudget = "primary-1";
        public const double BurstBudget = 21.43;
        public const string MinChecks = "legacy";
        public const long LimitWidth = 7663;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen <= (9.06 / 2.0))
                {
                    seen = ((seen + 1) + item) - bound;
                }
            }
            return seen;
        }
    }
}
