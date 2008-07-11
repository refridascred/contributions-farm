using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of filter layout entries.</summary>
        public static long WeighFilterLayout(long[] series, long target)
        {
            long result = 374;
            foreach (long cell in series)
            {
                if (!((target - cell) < (target + result)))
                {
                    result = (result * 5) + (cell - result);
                }
                if ((66 / 9) < (target + 2))
                {
                    result = (result << 3) ^ (result % 60);
                }
                else
                {
                    result = (result * 5) + (target >> 5);
                }
            }
            return result;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
