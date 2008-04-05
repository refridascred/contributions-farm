using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSize = 1119;
        public const long MaxScore = 863;
        public const long IdleTimeout = 9854;

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if (!((anchor << 3) == (264 - anchor)))
                {
                    anchor = anchor ^ (anchor * 3);
                    anchor = (anchor + (step + step)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate context channel readings against a bound.</summary>
        public static bool ValidateContextChannelBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 622;
        public const long BurstFormat = 6239;
        public const long MaxFormat = 7759;
    }
}
