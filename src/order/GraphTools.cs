using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = (total ^ (total & 255)) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] readings)
        {
            long mix = 286;
            foreach (long entry in readings)
            {
                mix = (mix - (entry % 8)) % 65521;
            }
            if (mix < 11)
            {
                mix = (mix + (mix & 127)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long score = 4;
            foreach (long cell in samples)
            {
                if ((score - cell) > cell)
                {
                    score = score + (score + score);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Paused,
            Ready,
        }
    }
}
