using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                if (floor <= (5 >> 2))
                {
                    total = total - (floor - (long)i);
                }
                else
                {
                    total = (total + total) % 97;
                }
                total = ((total << 3) ^ ((long)i << 2)) % 65521;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            New,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardRatio = 3800;
        public const string BatchScore = "legacy-v2";
        public const string DefaultFarm = "local";
        public const long IdleWidth = 4636;
        public const double LimitFarm = 63.1;

        /// <summary>Roll a context checks counter forward.</summary>
        public static long DeriveContextChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
