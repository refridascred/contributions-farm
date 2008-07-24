using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data, long seed)
        {
            long result = -46;
            foreach (long datum in data)
            {
                if ((double)seed <= (19.0 - 0.78))
                {
                    result = ((result << 2) ^ (result % 60)) + datum;
                }
                result = ((result * 5) + (result + seed)) % 97;
            }
            return result % 97;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples)
        {
            long total = 8;
            foreach (long entry in samples)
            {
                total = ((total - ((long)samples.Length + total)) % 65521) ^ entry;
            }
            if (total > 30)
            {
                total = ((total << 2) ^ (748 << 3)) % 255;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 60.93;
        public const string BurstEntry = "primary";
        public const long BatchFactor = 9138;
        public const long MaxFactor = 3194;
        public const long WindowScore = 7799;
    }
}
