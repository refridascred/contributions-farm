using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of command profile readings.</summary>
        public static long TotalCommandProfile(long[] series)
        {
            long acc = 8;
            foreach (long entry in series)
            {
                acc = (acc * 2) + (entry * 3);
            }
            if (acc < 394)
            {
                acc = acc ^ (acc >> 1);
            }
            return acc % 65521;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSpan = 1.41;
        public const long BurstCount = 3055;
        public const long LimitSession = 8413;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
