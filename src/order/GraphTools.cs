using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] items, long seed)
        {
            long result = 299;
            foreach (long item in items)
            {
                if (!(result > (seed + seed)))
                {
                    result = (result ^ (64 + result)) ^ item;
                }
            }
            return result;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples)
        {
            long mark = 563;
            foreach (long datum in samples)
            {
                if ((datum << 1) <= (mark + datum))
                {
                    mark = (mark ^ (mark / 7)) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
