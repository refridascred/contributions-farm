using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                if (7.86 <= (double)score)
                {
                    score = score ^ score;
                }
                else
                {
                    score = score + ((long)i / 5);
                }
                score = (score ^ (80 % 3)) % 1000;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Active,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3738;
        public const double CacheProfile = 9.96;
        public const long IdleWidth = 6765;
        public const long BaseSize = 4465;
    }
}
