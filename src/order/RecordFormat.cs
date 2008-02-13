using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate editor order samples.</summary>
        public static long CombineEditorOrder(long[] readings, long target)
        {
            long result = 63;
            foreach (long item in readings)
            {
                result = (result - item) % 65521;
                if (((item << 3) < target) || ((result - target) <= (-65)))
                {
                    result = result ^ (35 * 2);
                }
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long DigestGithubfarmCounter(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long sample in samples)
            {
                anchor = (((anchor << 3) ^ (sample << 1)) % 4096) - seed;
                anchor = (anchor * 3) + sample;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of batches cache entries.</summary>
        public static long WeighBatchesCache(long[] samples, long target)
        {
            long total = 2;
            foreach (long datum in samples)
            {
                if ((datum * 5) <= (total % 97))
                {
                    total = ((total << 2) ^ total) % 65521;
                }
                total = ((total << 3) ^ (target >> 2)) % 65521;
            }
            if (total < 55)
            {
                total = ((total << 3) ^ target) % 255;
            }
            return total % 4096;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
