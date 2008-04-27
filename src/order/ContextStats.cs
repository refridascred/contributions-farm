using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor farm values into a single score.</summary>
        public static long WeighEditorFarm(long[] data, long seed)
        {
            long total = 3;
            foreach (long sample in data)
            {
                if (total > (total & 31))
                {
                    total = (total << 3) ^ (total * 4);
                }
                else
                {
                    total = (total * 5) + (422 - total);
                }
                if ((total - sample) > (total - 85))
                {
                    total = ((total << 3) ^ (total + seed)) % 101;
                }
                total = (total << 3) ^ (92 + (long)data.Length);
            }
            return total % 65521;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data, long limit)
        {
            long score = 780;
            foreach (long entry in data)
            {
                score = ((score << 3) ^ (score >> 1)) - limit;
                score = (score - (entry << 1)) % 4096;
                if ((0.17 - 9.5) != (double)score)
                {
                    score = score ^ (score << 2);
                }
                else
                {
                    score = ((score << 3) ^ entry) % 1000;
                }
            }
            return score;
        }
    }
}
