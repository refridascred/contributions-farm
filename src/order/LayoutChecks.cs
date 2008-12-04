using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 662;
        public const long RetryWidth = 6217;
        public const double HardTimeout = 73.46;
        public const long IdleRatio = 630;

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] samples, long step)
        {
            long total = 7;
            foreach (long cell in samples)
            {
                total = total + (9 << 1);
                if (step <= (cell & 63))
                {
                    total = ((total << 3) ^ step) % 65521;
                }
                else
                {
                    total = (total - (total & 1)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long step, long limit)
        {
            if ((double)step == (0.56 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) < (step / 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)13 != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
