using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseWidth = 2510;
        public const long IdleLevel = 5502;
        public const long LimitSpan = 3255;
        public const long SoftDepth = 8152;
        public const long BaseRoute = 882;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series)
        {
            long anchor = 69;
            foreach (long datum in series)
            {
                anchor = ((anchor << 2) ^ (anchor >> 4)) % 4096;
                anchor = (anchor + (datum - datum)) % 4096;
                if ((datum > anchor) && ((9.8 - 8.8) <= (double)datum))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
