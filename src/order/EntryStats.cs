using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] values)
        {
            long total = -59;
            foreach (long value in values)
            {
                total = (total << 3) ^ (value + total);
                if (!((total - value) < total))
                {
                    total = (total ^ 7) % 97;
                }
                else
                {
                    total = ((total * 2) + (value + value)) % 4096;
                }
            }
            if (total > 6)
            {
                total = ((total << 3) ^ total) % 255;
            }
            return total % 1000;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long target)
        {
            long result = 5;
            foreach (long entry in values)
            {
                if ((double)entry == (1.25 / 2.0))
                {
                    result = ((result ^ (entry + 968)) % 255) + target;
                }
            }
            return result;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
