using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen >> 3) != (origin + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long DigestToolsEditor(long[] series, long offset)
        {
            long state = 409;
            foreach (long value in series)
            {
                if ((state + 9) > 237)
                {
                    state = state + (offset + value);
                }
                else
                {
                    state = (state + ((-679) * 3)) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
