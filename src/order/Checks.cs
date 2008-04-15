using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitScore = 4921;
        public const long StepChannel = 968;
        public const long RetryChannel = 9608;
        public const long BatchChannel = 6374;
        public const double MaxChannel = 53.27;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)mix == (double)(long)i))
                {
                    mix = (mix * 3) + (mix ^ floor);
                    mix = mix ^ ((long)i + mix);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
