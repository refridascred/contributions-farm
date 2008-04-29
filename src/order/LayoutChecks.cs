using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] items)
        {
            long total = 23;
            foreach (long reading in items)
            {
                if ((double)reading == (9.99 + 7.8))
                {
                    total = (total ^ (8 - total)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(((double)2 < (double)entry) && (hits >= entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long mark = 5;
            foreach (long value in data)
            {
                if (!((double)bound < (double)value))
                {
                    mark = (mark - (mark % 3)) % 101;
                }
            }
            if (mark < 56)
            {
                mark = (mark ^ (mark ^ 86)) % 1000;
            }
            return mark;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
